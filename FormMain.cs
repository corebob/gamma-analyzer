﻿/*	
	Crash - Controlling application for Burn
    Copyright (C) 2016  Norwegian Radiation Protection Authority

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
// Authors: Dag robole,

using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Net;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using ZedGraph;
//using IronPython.Hosting;
//using IronPython.Runtime;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using Newtonsoft.Json;

namespace crash
{
    public partial class FormMain : Form
    {
        CrashSettings settings = new CrashSettings();

        static ConcurrentQueue<burn.Message> sendq = null;
        static ConcurrentQueue<burn.Message> recvq = null;

        static burn.NetService netService = new burn.NetService(ref sendq, ref recvq);
        static Thread netThread = new Thread(netService.DoWork);
        
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        bool connected = false;
        Session session = new Session();
        Session background = new Session();

        FormConnect formConnect = null;
        FormWaterfallLive formWaterfallLive = null;
        FormROILive formROILive = null;
        FormMap formMap = null; 

        PointPairList setupGraphList = new PointPairList();
        PointPairList sessionGraphList = new PointPairList();
        PointPairList bkgGraphList = new PointPairList();

        Detector selectedDetector = null;
        DetectorType selectedDetectorType = null;
        
        float bkgScale = 1f;

        public FormMain()
        {
            InitializeComponent();            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(CrashEnvironment.SettingsPath))
                Directory.CreateDirectory(CrashEnvironment.SettingsPath);

            if (!Directory.Exists(CrashEnvironment.GEScriptPath))
                Directory.CreateDirectory(CrashEnvironment.GEScriptPath);            

            if (File.Exists(CrashEnvironment.SettingsFile))
                LoadSettings();            

            formConnect = new FormConnect();
            formWaterfallLive = new FormWaterfallLive(settings.ROIList);
            formROILive = new FormROILive(settings.ROIList);
            formMap = new FormMap();

            tabs.HideTabs = true;
            tabs.SelectedTab = pageMenu;

            lblConnectionStatus.ForeColor = Color.Red;
            lblConnectionStatus.Text = "Not connected";            
            lblSetupChannel.Text = "";
            lblSessionChannel.Text = "";
            lblDetector.Text = "";
            separatorDetector.Visible = false;

            ClearSpectrumInfo();            

            formWaterfallLive.SetSessionIndexEvent += SetSessionIndexEvent;
            formMap.SetSessionIndexEvent += SetSessionIndexEvent;
            formROILive.SetSessionIndexEvent += SetSessionIndexEvent;

            PopulateDetectors();
            PopulateBackgroundSessions();

            netThread.Start();
            while (!netThread.IsAlive);            
                    
            timer.Interval = 10;
            timer.Tick += timer_Tick;
            timer.Start();            
        }        

        void SetSessionIndexEvent(object sender, SetSessionIndexEventArgs e)
        {
            if(e.StartIndex == -1 && e.EndIndex == -1)
            {
                lbSession.ClearSelected();
                return;
            }

            if (e.StartIndex >= lbSession.Items.Count || e.EndIndex >= lbSession.Items.Count || e.StartIndex < 0 || e.EndIndex < 0)
                return;

            lbSession.ClearSelected();

            if (e.StartIndex > e.EndIndex)
            {
                int tmp = e.StartIndex;
                e.StartIndex = e.EndIndex;
                e.EndIndex = tmp;
            }            

            if (e.StartIndex == e.EndIndex)
            {
                int idx1 = lbSession.FindStringExact(session.Info.Name + " - " + e.StartIndex.ToString());
                if (idx1 != ListBox.NoMatches)             
                    lbSession.SetSelected(idx1, true);                
            }
            else
            {
                int idx1 = lbSession.FindStringExact(session.Info.Name + " - " + e.StartIndex.ToString());
                int idx2 = lbSession.FindStringExact(session.Info.Name + " - " + e.EndIndex.ToString());
                for(int i=idx1; i<idx2; i++)
                {
                    lbSession.SetSelected(i, true);
                }
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            while (!recvq.IsEmpty)
            {
                burn.Message msg;                
                if (recvq.TryDequeue(out msg))
                    dispatchRecvMsg(msg);                                    
            }            
        }        

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (netService.IsRunning())
                btnStopNetService_Click(sender, e);
            timer.Stop();

            SaveSettings();
        }        

        public void PopulateBackgroundSessions()
        {            
            bkgScale = 1.0f; // FIXME
        }

        private void SaveSettings()
        {
            StreamWriter sw = new StreamWriter(CrashEnvironment.SettingsFile);
            XmlSerializer x = new XmlSerializer(settings.GetType());
            x.Serialize(sw, settings);
            sw.Close();
        }

        private void LoadSettings()
        {
            if (File.Exists(CrashEnvironment.SettingsFile))
            {
                StreamReader sr = new StreamReader(CrashEnvironment.SettingsFile);
                XmlSerializer x = new XmlSerializer(settings.GetType());
                settings = x.Deserialize(sr) as CrashSettings;
                sr.Close();
            }
        }        

        private bool dispatchRecvMsg(burn.Message msg)
        {            
            switch (msg.Command)
            {
                case "connect_ok":
                    lblConnectionStatus.ForeColor = Color.Green;
                    lblConnectionStatus.Text = "Connected to " + msg.Arguments["host"] + ":" + msg.Arguments["port"];
                    Utils.Log.Add("Connected to " + msg.Arguments["host"] + ":" + msg.Arguments["port"]);
                    connected = true;
                    break;

                case "connect_failed":
                    lblConnectionStatus.ForeColor = Color.Red;
                    lblConnectionStatus.Text = "Connection failed for " + msg.Arguments["host"] + ":" + msg.Arguments["port"] + " " + msg.Arguments["message"];
                    Utils.Log.Add("Connection failed for " + msg.Arguments["host"] + ":" + msg.Arguments["port"] + " " + msg.Arguments["message"]);
                    connected = false;
                    break;

                case "disconnect_ok":
                    lblConnectionStatus.ForeColor = Color.Red;
                    lblConnectionStatus.Text = "Not connected";
                    Utils.Log.Add("Disconnected from peer");
                    connected = false;
                    break;

                case "close_ok":
                    netService.RequestStop();
                    netThread.Join();
                    lblConnectionStatus.ForeColor = Color.Red;
                    lblConnectionStatus.Text = "Not connected";
                    Utils.Log.Add("Disconnected from peer, peer closed");
                    break;

                case "new_session_ok":
                    bool prev = msg.Arguments["preview"].ToString() == "1";
                    if(prev)
                        Utils.Log.Add("Preview received");
                    else
                    {
                        string sessionName = msg.Arguments["session_name"].ToString();
                        Utils.Log.Add("New session created: " + sessionName);

                        string geScript = File.ReadAllText(selectedDetectorType.GEScriptPath);
                        session = new Session(settings.SessionRootDirectory, sessionName, tbSessionComment.Text, selectedDetector, geScript);                        
                        
                        string sessionSettingsFile = session.SessionPath + Path.DirectorySeparatorChar + "session.json";
                        string jSessionInfo = JsonConvert.SerializeObject(session.Info, Newtonsoft.Json.Formatting.Indented);
                        TextWriter writer = new StreamWriter(sessionSettingsFile);
                        writer.Write(jSessionInfo);
                        writer.Close();                                                

                        formWaterfallLive.SetSession(session);
                        formROILive.SetSession(session);
                        formMap.SetSession(session);                        
                    }                        
                    break;

                case "new_session_failed":
                    Utils.Log.Add("New session failed: " + msg.Arguments["message"]);
                    break;

                case "stop_session_ok":
                    Utils.Log.Add("Session stopped");
                    break;

                case "session_finished":
                    Utils.Log.Add("Session " + msg.Arguments["session_name"] + " finished");
                    PopulateBackgroundSessions();
                    break;

                case "error":
                    Utils.Log.Add("Error: " + msg.Arguments["message"]);
                    break;

                case "error_socket":
                    Utils.Log.Add("Socket error: " + msg.Arguments["error_code"] + " " + msg.Arguments["message"]);
                    break;                

                case "set_gain_ok":
                    Utils.Log.Add("set gain: " + msg.Arguments["voltage"] + " " + msg.Arguments["coarse_gain"] + " " + msg.Arguments["fine_gain"]);
                    break;

                case "spectrum":

                    Spectrum spec = new Spectrum(msg);
                    Utils.Log.Add(spec.Label + " received");                                                            

                    if (spec.IsPreview)
                    {                        
                        GraphPane pane = graphSetup.GraphPane;
                        pane.Chart.Fill = new Fill(SystemColors.ButtonFace);
                        pane.Fill = new Fill(SystemColors.ButtonFace);                        

                        pane.Title.Text = "Setup";
                        pane.XAxis.Title.Text = "Channel";
                        pane.YAxis.Title.Text = "Counts";

                        setupGraphList.Clear();
                        for (int i = 0; i < spec.Channels.Count; i++)
                            setupGraphList.Add((double)i, (double)spec.Channels[i]);

                        pane.XAxis.Scale.Min = 0;
                        pane.XAxis.Scale.Max = spec.MaxCount;

                        pane.YAxis.Scale.Min = 0;
                        pane.YAxis.Scale.Max = spec.MaxCount + (spec.MaxCount / 10.0);

                        pane.CurveList.Clear();

                        LineItem curve = pane.AddCurve("Spectrum", setupGraphList, Color.Red, SymbolType.None);
                        curve.Line.Fill = new Fill(SystemColors.ButtonFace, Color.Red, 45F);                        
                        pane.Chart.Fill = new Fill(SystemColors.ButtonFace, SystemColors.ButtonFace);
                        pane.Legend.Fill = new Fill(SystemColors.ButtonFace, SystemColors.ButtonFace);                        
                        pane.Fill = new Fill(SystemColors.ButtonFace, SystemColors.ButtonFace);                        

                        graphSetup.RestoreScale(pane);
                        graphSetup.AxisChange();
                        graphSetup.Refresh();                        
                    }
                    else
                    {         
                        // Make sure session is allocated in case spectrums are ticking in                                              

                        string jsonPath = session.SessionPath + Path.DirectorySeparatorChar + "json";
                        if (!Directory.Exists(jsonPath))
                            Directory.CreateDirectory(jsonPath);

                        string json = JsonConvert.SerializeObject(msg, Newtonsoft.Json.Formatting.Indented);
                        TextWriter writer = new StreamWriter(jsonPath + Path.DirectorySeparatorChar + spec.SessionIndex + ".json");
                        writer.Write(json);
                        writer.Close();

                        if(session.IsLoaded)
                            spec.CalculateDoserate(session.Info.Detector, session.GEFactor);

                        session.Add(spec);

                        // Add list node
                        lbSession.Items.Insert(0, spec);

                        formMap.AddMarker(spec);
                        formWaterfallLive.UpdatePane();
                        formROILive.UpdatePane();
                    }                                            
                    break;

                default:
                    string info = msg.Command + " -> ";
                    foreach (KeyValuePair<string, object> item in msg.Arguments)
                        info += item.Key + ":" + item.Value.ToString() + ", ";
                    Utils.Log.Add("Unhandeled command: " + info);
                    break;
            }
            return true;
        }                

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            menuItemDisconnect_Click(sender, e);
            Close();
        }

        private void menuItemConnect_Click(object sender, EventArgs e)
        {
            formConnect.IP = settings.LastIP;
            formConnect.Port = settings.LastPort;
            if (formConnect.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            settings.LastIP = formConnect.IP;
            settings.LastPort = formConnect.Port;

            burn.Message msg = new burn.Message("connect", null);
            msg.AddParameter("host", formConnect.IP);
            msg.AddParameter("port", formConnect.Port);            
            sendq.Enqueue(msg);           
        }

        private void menuItemDisconnect_Click(object sender, EventArgs e)
        {        
            if(connected)
                if (MessageBox.Show("Are you sure you want to disconnect?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

            sendq.Enqueue(new burn.Message("disconnect", null));
        }        

        private void btnSendClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the remote server?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            sendq.Enqueue(new burn.Message("close", null));                        
        }

        private void btnSendSession_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(settings.SessionRootDirectory))
            {
                MessageBox.Show("You must provide a session directory under preferences");
                return;
            }   
            
            if(selectedDetector == null)
            {
                MessageBox.Show("You must specify a detector under setup");
                return;
            }

            if (String.IsNullOrEmpty(tbSpecLivetime.Text))
            {
                MessageBox.Show("You must specify a livetime");
                return;
            }            

            int count = String.IsNullOrEmpty(tbSpecCount.Text) ? -1 : Convert.ToInt32(tbSpecCount.Text);
            float livetime = Convert.ToSingle(tbSpecLivetime.Text);
            float delay = String.IsNullOrEmpty(tbSpecDelay.Text) ? 0 : Convert.ToSingle(tbSpecDelay.Text);

            ClearSession();

            burn.Message msg = new burn.Message("new_session", null);
            msg.AddParameter("session_name", String.Format("{0:ddMMyyyy_HHmmss}", DateTime.Now));
            msg.AddParameter("preview", 0);
            msg.AddParameter("iterations", count);
            msg.AddParameter("livetime", livetime);
            msg.AddParameter("delay", delay);
            sendq.Enqueue(msg);            
        }

        private void ClearSpectrumInfo()
        {
            lblRealtime.Text = "";
            lblLivetime.Text = "";
            lblSession.Text = "";
            lblIndex.Text = "";
            lblLatitudeStart.Text = "";
            lblLongitudeStart.Text = "";
            lblAltitudeStart.Text = "";
            lblLatitudeEnd.Text = "";
            lblLongitudeEnd.Text = "";
            lblAltitudeEnd.Text = "";
            lblGpsTimeStart.Text = "";
            lblGpsTimeEnd.Text = "";
            lblMaxCount.Text = "";
            lblMinCount.Text = "";
            lblTotalCount.Text = "";
            lblDoserate.Text = "";
        }

        private void ClearSession()
        {
            lbSession.Items.Clear();
            graphSession.GraphPane.CurveList.Clear();
            graphSession.GraphPane.GraphObjList.Clear();
            graphSession.Invalidate();
            ClearSpectrumInfo();

            formWaterfallLive.ClearSession();
            formROILive.ClearSession();
            formMap.ClearSession();
        }

        private void btnStopNetService_Click(object sender, EventArgs e)
        {
            netService.RequestStop();
            netThread.Join();
        }                
        
        private void btnStopSession_Click(object sender, EventArgs e)
        {
            sendq.Enqueue(new burn.Message("stop_session", null));
        }
        
        private void btnMenuSpec_Click(object sender, EventArgs e)
        {
            tabs.SelectedTab = pageSetup;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabs.SelectedTab = pageMenu;
        }        

        private void btnMenuMap_Click(object sender, EventArgs e)
        {
            tabs.SelectedTab = pageSession;
        }        

        private void btnMenuSession_Click(object sender, EventArgs e)
        {
            tabs.SelectedTab = pageSession;
        }
        
        private void btnSetupSetParams_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbSetupVoltage.Text))
            {
                MessageBox.Show("You must specify voltage");
                return;
            }

            if (String.IsNullOrEmpty(tbSetupCoarseGain.Text))
            {
                MessageBox.Show("You must specify coarse gain");
                return;
            }

            if (String.IsNullOrEmpty(tbSetupFineGain.Text))
            {
                MessageBox.Show("You must specify fine gain");
                return;
            }

            int voltage = Convert.ToInt32(tbSetupVoltage.Text);
            float coarse = Convert.ToSingle(tbSetupCoarseGain.Text);
            float fine = Convert.ToSingle(tbSetupFineGain.Text);

            burn.Message msg = new burn.Message("set_gain", null);
            msg.AddParameter("voltage", voltage);
            msg.AddParameter("coarse_gain", coarse);
            msg.AddParameter("fine_gain", fine);
            sendq.Enqueue(msg);
        }

        private void btnSetupStart_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbSetupLivetime.Text))
            {
                MessageBox.Show("You must specify a livetime");
                return;
            }

            burn.Message msg = new burn.Message("new_session", null);
            msg.AddParameter("session_name", String.Format("{0:ddMMyyyy_HHmmss}", DateTime.Now));
            msg.AddParameter("preview", 1);
            msg.AddParameter("iterations", 1);
            msg.AddParameter("livetime", Convert.ToSingle(tbSetupLivetime.Text));
            msg.AddParameter("delay", 0);
            sendq.Enqueue(msg);
        }

        private void btnSetupStop_Click(object sender, EventArgs e)
        {
            sendq.Enqueue(new burn.Message("stop_session", null));
        }

        private void btnSetupStoreParams_Click(object sender, EventArgs e)
        {            
        }                

        private void menuItemPreferences_Click(object sender, EventArgs e)
        {
            FormPreferences form = new FormPreferences(settings);
            if(form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PopulateDetectors();
            }
        }

        private void btnShowWaterfall_Click(object sender, EventArgs e)
        {
            formWaterfallLive.Show();
            formWaterfallLive.BringToFront();
            formWaterfallLive.UpdatePane();
        }        

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblInterface.Text = tabs.SelectedTab.Text;

            btnBack.Enabled = true;
            btnShowMap.Enabled = false;
            btnShowWaterfallLive.Enabled = false;
            btnShowROIChart.Enabled = false;
            btnShowDoserate.Enabled = false;

            if (tabs.SelectedTab == pageMenu)            
                btnBack.Enabled = false;            

            if (tabs.SelectedTab == pageSession)
            {
                btnShowMap.Enabled = true;
                btnShowWaterfallLive.Enabled = true;
                btnShowROIChart.Enabled = true;
                btnShowDoserate.Enabled = true;
            }            
        }                                

        private void btnShowROIChart_Click(object sender, EventArgs e)
        {
            formROILive.Show();
            formROILive.BringToFront();
        }

        private void btnShowMap_Click(object sender, EventArgs e)
        {
            formMap.Show();
            formMap.BringToFront();
        }

        private void btnShowLog_Click(object sender, EventArgs e)
        {
            Utils.Log.Show();
            Utils.Log.BringToFront();
        }

        public void ShowSpectrum(string title, float[] channels, float maxCount, float minCount)
        {
            GraphPane pane = graphSession.GraphPane;
            pane.Chart.Fill = new Fill(SystemColors.ButtonFace);
            pane.Fill = new Fill(SystemColors.ButtonFace);

            pane.Title.Text = title;
            pane.XAxis.Title.Text = "Channel";
            pane.YAxis.Title.Text = "Counts";                        

            pane.XAxis.Scale.Min = 0;
            pane.XAxis.Scale.Max = maxCount;

            pane.YAxis.Scale.Min = minCount;
            pane.YAxis.Scale.Max = maxCount + (maxCount / 10.0);

            pane.CurveList.Clear();            
            
            if(!background.IsEmpty)            
            {
                float[] spec = background.GetAdjustedCounts(session.Spectrums[0].Livetime);
                bkgGraphList.Clear();
                for (int i = 0; i < spec.Length; i++)
                    bkgGraphList.Add((double)i, (double)spec[i] * bkgScale);

                LineItem bkgCurve = pane.AddCurve("Background", bkgGraphList, Color.Blue, SymbolType.None);                
            }
            
            sessionGraphList.Clear();            
            for (int i = 0; i < channels.Length; i++)
                sessionGraphList.Add((double)i, (double)channels[i]);

            LineItem curve = pane.AddCurve("Spectrum", sessionGraphList, Color.Red, SymbolType.None);                                                
            
            pane.Chart.Fill = new Fill(SystemColors.ButtonFace, SystemColors.ButtonFace);
            pane.Legend.Fill = new Fill(SystemColors.ButtonFace, SystemColors.ButtonFace);
            pane.Fill = new Fill(SystemColors.ButtonFace, SystemColors.ButtonFace);                        

            graphSession.RestoreScale(pane);
            graphSession.AxisChange();
            graphSession.Refresh();
        }

        private void lbSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSession.SelectedItems.Count < 1)
            {
                formWaterfallLive.SetSelectedSessionIndex(-1);
                formMap.SetSelectedSessionIndex(-1);
                formROILive.SetSelectedSessionIndex(-1);
                return;
            }                
            else if (lbSession.SelectedItems.Count == 1)
            {
                bkgScale = 1;
                Spectrum s = lbSession.SelectedItem as Spectrum;
                ShowSpectrum(s.SessionName + " - " + s.SessionIndex.ToString(), s.Channels.ToArray(), s.MaxCount, s.MinCount);
                lblRealtime.Text = "Realtime:" + ((double)s.Realtime) / 1000000.0;
                lblLivetime.Text = "Livetime:" + ((double)s.Livetime) / 1000000.0;
                lblSession.Text = "Name: " + s.SessionName;
                lblIndex.Text = "Index: " + s.SessionIndex;
                lblLatitudeStart.Text = "Lat. start: " + s.LatitudeStart;
                lblLongitudeStart.Text = "Lon. start: " + s.LongitudeStart;
                lblAltitudeStart.Text = "Alt. start: " + s.AltitudeStart;
                lblLatitudeEnd.Text = "Lat. end: " + s.LatitudeEnd;
                lblLongitudeEnd.Text = "Lon. end: " + s.LongitudeEnd;
                lblAltitudeEnd.Text = "Alt. end: " + s.AltitudeEnd;
                lblGpsTimeStart.Text = "Gps time start: " + s.GpsTimeStart;
                lblGpsTimeEnd.Text = "Gps time end: " + s.GpsTimeEnd;
                lblMaxCount.Text = "Max count: " + s.MaxCount;
                lblMinCount.Text = "Min count: " + s.MinCount;
                lblTotalCount.Text = "Total count: " + s.TotalCount;
                if(s.Doserate == 0.0)
                    lblDoserate.Text = "";
                else lblDoserate.Text = "Doserate: " + String.Format("{0:###0.0##}", s.Doserate);

                formWaterfallLive.SetSelectedSessionIndex(s.SessionIndex);
                formMap.SetSelectedSessionIndex(s.SessionIndex);
                formROILive.SetSelectedSessionIndex(s.SessionIndex);
            }
            else
            {
                bkgScale = (float)lbSession.SelectedIndices.Count;

                Spectrum s1 = (Spectrum)lbSession.Items[lbSession.SelectedIndices[lbSession.SelectedIndices.Count - 1]];
                Spectrum s2 = (Spectrum)lbSession.Items[lbSession.SelectedIndices[0]];

                double realTime = 0;
                double liveTime = 0;

                string title = "Merged: " + s1.SessionIndex + " - " + s2.SessionIndex;
                float[] chans = new float[(int)s1.NumChannels];
                float maxCnt = s1.MaxCount, minCnt = s1.MinCount;
                float totCnt = 0;                
                for(int i=0; i<lbSession.SelectedItems.Count; i++)
                {
                    Spectrum s = (Spectrum)lbSession.SelectedItems[i];
                    for(int j=0; j<s.NumChannels; j++)                    
                        chans[j] += s.Channels[j];                                            

                    if (s.MaxCount > maxCnt)
                        maxCnt = s.MaxCount;
                    if (s.MinCount < minCnt)
                        minCnt = s.MinCount;

                    totCnt += s.TotalCount;                

                    realTime += ((double)s.Realtime) / 1000000.0;
                    liveTime += ((double)s.Livetime) / 1000000.0;                    
                }

                ShowSpectrum(title, chans, maxCnt, minCnt);

                lblRealtime.Text = "Realtime:" + realTime;
                lblLivetime.Text = "Livetime:" + liveTime;
                lblSession.Text = "Session name: " + s1.SessionName;
                lblIndex.Text = "Session index: " + s1.SessionIndex + " - " + s2.SessionIndex;
                lblLatitudeStart.Text = "Lat. start: " + s1.LatitudeStart;
                lblLongitudeStart.Text = "Lon. start: " + s1.LongitudeStart;
                lblAltitudeStart.Text = "Alt. start: " + s1.AltitudeStart;
                lblLatitudeEnd.Text = "Lat. end: " + s2.LatitudeEnd;
                lblLongitudeEnd.Text = "Lon. end: " + s2.LongitudeEnd;
                lblAltitudeEnd.Text = "Alt. end: " + s2.AltitudeEnd;
                lblGpsTimeStart.Text = "Gps time start: " + s1.GpsTimeStart;
                lblGpsTimeEnd.Text = "Gps time end: " + s2.GpsTimeEnd;
                lblMaxCount.Text = "Max count: " + maxCnt;
                lblMinCount.Text = "Min count: " + minCnt;
                lblTotalCount.Text = "Total count: " + totCnt;                
                lblDoserate.Text = "";

                formWaterfallLive.SetSelectedSessionIndices(s1.SessionIndex, s2.SessionIndex);
                formMap.SetSelectedSessionIndices(s1.SessionIndex, s2.SessionIndex);
                formROILive.SetSelectedSessionIndices(s1.SessionIndex, s2.SessionIndex);
            }
        }        

        private void btnShow3D_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented");
        }        

        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();            
        }        

        private void PopulateDetectors()
        {
            cboxSetupDetector.Items.Clear();      
            cboxSetupDetector.Items.AddRange(settings.Detectors.ToArray());            
        }        

        private void menuItemLoadSession_Click(object sender, EventArgs e)
        {
            ClearSession();
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = settings.SessionRootDirectory;
            dialog.Description = "Select session directory";
            dialog.ShowNewFolderButton = false;
            if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                session.Load(dialog.SelectedPath);
                tbSessionComment.Text = session.Info.Comment;

                formWaterfallLive.SetSession(session);
                formROILive.SetSession(session);
                formMap.SetSession(session);

                foreach(Spectrum s in session.Spectrums)
                {
                    lbSession.Items.Insert(0, s);
                    formMap.AddMarker(s);
                }                

                formWaterfallLive.UpdatePane();
                formROILive.UpdatePane();
            }
        }        

        private void menuItemLoadBackgroundSession_Click(object sender, EventArgs e)
        {
            if (!session.IsLoaded)
            {
                MessageBox.Show("Session is not loaded");
                return;
            }

            FolderBrowserDialog dialog = new FolderBrowserDialog();            
            dialog.SelectedPath = settings.SessionRootDirectory;
            dialog.Description = "Select background session directory";
            dialog.ShowNewFolderButton = false;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                background.Load(dialog.SelectedPath);
            }
        }

        private void menuItemSaveCHN_Click(object sender, EventArgs e)
        {
            if(session.IsEmpty)
            {
                MessageBox.Show("No session active");
                return;
            }

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = true;
            dialog.Description = "Select folder to store CHN files";
            if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    SessionExporter.CHN(session, dialog.SelectedPath);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Failed to export session to CHN format: " + ex.Message);
                }                    
            }
        }

        private void menuItemROITable_Click(object sender, EventArgs e)
        {
            FormROITable form = new FormROITable(settings.ROIList);
            form.ShowDialog();            
        }

        private void btnShowRegressionPoints_Click(object sender, EventArgs e)
        {
            if (selectedDetector == null)
            {
                MessageBox.Show("You must select a detector first");
                return;
            }   
             
            FormRegressionPoints form = new FormRegressionPoints(selectedDetector);
            form.Show();
        }        

        private void graphSetup_MouseMove(object sender, MouseEventArgs e)
        {
            // Get point from graph
            int index = 0;
            object nearestobject = null;
            PointF clickedPoint = new PointF(e.X, e.Y);
            graphSetup.GraphPane.FindNearestObject(clickedPoint, this.CreateGraphics(), out nearestobject, out index);        
            double x, y;            
            graphSetup.GraphPane.ReverseTransform(clickedPoint, out x, out y);

            lblSetupChannel.Text = "Channel: " + String.Format("{0:###0}", x);
        }

        private void graphSession_MouseMove(object sender, MouseEventArgs e)
        {
            // Get point from graph
            int index = 0;
            object nearestobject = null;
            PointF clickedPoint = new PointF(e.X, e.Y);
            graphSession.GraphPane.FindNearestObject(clickedPoint, this.CreateGraphics(), out nearestobject, out index);
            double x, y;
            graphSession.GraphPane.ReverseTransform(clickedPoint, out x, out y);

            lblSessionChannel.Text = "Channel: " + String.Format("{0:###0}", x);
        }

        private void menuItemSessionUnselect_Click(object sender, EventArgs e)
        {
            lbSession.ClearSelected();            
        }

        private void cboxSetupDetector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxSetupDetector.SelectedItem == null)
                return;

            selectedDetector = (Detector)cboxSetupDetector.SelectedItem;
            selectedDetectorType = settings.DetectorTypes.Find(dt => dt.Name == selectedDetector.TypeName);

            lblDetector.Text = "Detector " + selectedDetector.Serialnumber;
            separatorDetector.Visible = true;
            
            btnMenuSession.Enabled = true;
            btnShowRegressionPoints.Enabled = true;

            cboxSetupChannels.Text = selectedDetector.CurrentNumChannels.ToString();
            tbSetupVoltage.Text = selectedDetector.CurrentHV.ToString();
            tbSetupCoarseGain.Text = selectedDetector.CurrentCoarseGain.ToString();
            tbSetupFineGain.Text = selectedDetector.CurrentFineGain.ToString();
            tbSetupLLD.Text = selectedDetector.CurrentLLD.ToString();
            tbSetupULD.Text = selectedDetector.CurrentULD.ToString();
            cboxSetupChannels.Items.Clear();
            for(int i = 256; i <= selectedDetectorType.MaxNumChannels; i = i * 2)            
                cboxSetupChannels.Items.Add(i.ToString());
            cboxSetupChannels.Text = selectedDetector.CurrentNumChannels.ToString();
        }
    }    
}
