﻿/*	
	Gamma Analyzer - Controlling application for Burn
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
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using log4net;

namespace crash
{
    public partial class FormMap : Form
    {
        private FormContainer parent = null;
        private GASettings settings = null;
        private ILog log = null;

        private Session currentSession = null;
        private GMapOverlay overlay = new GMapOverlay();

        public FormMap(FormContainer p, GASettings s, ILog l)
        {
            InitializeComponent();

            MdiParent = parent = p;
            settings = s;
            log = l;
        }

        private void FormMap_Load(object sender, EventArgs e)
        {
            try
            {
                gmnMap.Overlays.Add(overlay);
                gmnMap.Position = new PointLatLng(59.946534, 10.598574);

                gmnMap.MapProvider = ArcGIS_World_Topo_MapProvider.Instance;
                int idx = cboxMapProvider.FindString("ArcGIS World Topo");
                if (idx >= 0)
                    cboxMapProvider.SelectedIndex = idx;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }

        private void cboxMapMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cboxMapMode.Text))
            {
                switch (cboxMapMode.Text)
                {
                    case "Server":
                        GMaps.Instance.Mode = AccessMode.ServerOnly;
                        break;
                    case "Cache":
                        GMaps.Instance.Mode = AccessMode.CacheOnly;
                        break;
                    default:
                        GMaps.Instance.Mode = AccessMode.ServerAndCache;
                        break;
                }
            }            
        }

        private void cboxMapProvider_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (!String.IsNullOrEmpty(cboxMapProvider.Text))
            {
                switch (cboxMapProvider.Text)
                {
                    case "Google Map":
                        gmnMap.MapProvider = GoogleMapProvider.Instance;
                        break;
                    case "Google Map Terrain":
                        gmnMap.MapProvider = GoogleTerrainMapProvider.Instance;
                        break;
                    case "Google Map Satellite":
                        gmnMap.MapProvider = GoogleSatelliteMapProvider.Instance;
                        GMaps.Instance.Mode = AccessMode.ServerAndCache;
                        gmnMap.Zoom = 5;
                        gmnMap.MaxZoom = 18;
                        gmnMap.MinZoom = 2;
                        gmnMap.Bearing = 0;
                        gmnMap.CanDragMap = true;
                        break;
                    case "Open Street Map":
                        gmnMap.MapProvider = OpenStreetMapProvider.Instance;
                        break;
                    case "Open Street Map Quest":
                        gmnMap.MapProvider = OpenStreetMapQuestProvider.Instance;
                        break;
                    case "ArcGIS World Topo":
                        gmnMap.MapProvider = ArcGIS_World_Topo_MapProvider.Instance;
                        break;
                    case "ArcGIS World 2D":
                        gmnMap.MapProvider = ArcGIS_Imagery_World_2D_MapProvider.Instance;
                        break;                    
                    case "ArcGIS World Shaded":
                        gmnMap.MapProvider = ArcGIS_World_Shaded_Relief_MapProvider.Instance;
                        break;                    
                    case "Bing Map":
                        gmnMap.MapProvider = BingMapProvider.Instance;                         
                        break;
                    case "Bing Map Hybrid":
                        gmnMap.MapProvider = BingHybridMapProvider.Instance;
                        break;
                    case "Bing Map Satellite":
                        gmnMap.MapProvider = BingSatelliteMapProvider.Instance;
                        break;
                    case "Yahoo Map":
                        gmnMap.MapProvider = YahooMapProvider.Instance;
                        break;
                    case "Yahoo Map Hybrid":
                        gmnMap.MapProvider = YahooHybridMapProvider.Instance;                        
                        break;
                    case "Yahoo Map Satellite":                        
                        gmnMap.MapProvider = YahooSatelliteMapProvider.Instance;
                        break;
                }
            }
        }  
      
        private void RemoveAllMarkers()
        {
            GMapPoint.MinDoserate = 0d;
            GMapPoint.MaxDoserate = 0d;

            if (overlay == null)
                return;

            for(int i = 0; i < overlay.Markers.Count; i++)            
                overlay.Markers.RemoveAt(i);
            overlay.Markers.Clear();
            overlay.Clear();
            gmnMap.Overlays.Remove(overlay);

            overlay = new GMapOverlay();
            gmnMap.Overlays.Add(overlay);
            gmnMap.Refresh();
        }

        public void SetSession(Session sess)
        {
            currentSession = sess;
            RemoveAllMarkers();

            foreach(Spectrum spec in currentSession.Spectrums)            
                AddMarker(spec);            

            if(currentSession.Spectrums.Count > 0)
                gmnMap.Position = new GMap.NET.PointLatLng(currentSession.Spectrums[0].Latitude, currentSession.Spectrums[0].Longitude);
        }

        public void AddMarker(Spectrum s)
        {
            if (currentSession == null)
                return;
                        
            double minDose = currentSession.Spectrums.Min(x => x.Doserate);
            GMapPoint.MinDoserate = minDose <= 0 ? 0 : Math.Log(minDose);
            double maxDose = currentSession.Spectrums.Max(x => x.Doserate);
            GMapPoint.MaxDoserate = maxDose <= 0 ? 0 : Math.Log(maxDose);

            // Add map marker
            GMapPoint marker = new GMapPoint(new PointLatLng(s.Latitude, s.Longitude), new Size(12, 12));
            marker.Tag = s;
            marker.ToolTipText = s.ToString()
                + Environment.NewLine + "Latitude: " + s.Latitude.ToString("#00.0000000")
                + Environment.NewLine + "Longitude: " + s.Longitude.ToString("#00.0000000")
                + Environment.NewLine + "Altitude: " + s.Altitude.ToString("#####0.0#")
                + Environment.NewLine + "Doserate: " + String.Format("{0:###0.0##}", s.Doserate / 1000.0) + " μSv/h";
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            overlay.Markers.Add(marker);
        }                        

        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {                                    
            Spectrum s = item.Tag as Spectrum;
            parent.SetSelectedSessionIndex(s.SessionIndex);
        }

        public void SetSelectedSessionIndex(int index)
        {
            foreach (GMapPoint m in overlay.Markers)
            {                   
                Spectrum s = m.Tag as Spectrum;
                if (s.SessionIndex == index)                
                    m.ToolTipMode = MarkerTooltipMode.Always;                                
                else                
                    m.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            }
            gmnMap.Refresh();
        }

        public void SetSelectedSessionIndices(int index1, int index2)
        {
            foreach (GMapPoint m in overlay.Markers)
            {
                Spectrum s = m.Tag as Spectrum;
                if (s.SessionIndex >= index1 && s.SessionIndex <= index2)                
                    m.ToolTipMode = MarkerTooltipMode.Always;
                else                
                    m.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            }
            gmnMap.Refresh();
        }

        public void ClearSession()
        {
            currentSession = null;
            RemoveAllMarkers();
        }

        private void btnZoomToMax_Click(object sender, EventArgs e)
        {
            gmnMap.Zoom = (double)gmnMap.MinZoom;
        }

        private void btnZoomToMin_Click(object sender, EventArgs e)
        {
            gmnMap.Zoom = (double)gmnMap.MaxZoom;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            gmnMap.Zoom -= 1.0;
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            gmnMap.Zoom += 1.0;
        }

        private void menuItemIAEAColors_CheckedChanged(object sender, EventArgs e)
        {
            GMapPoint.UseIAEAColors = menuItemIAEAColors.Checked;
            gmnMap.Refresh();
        }

        private void FormMap_FormClosing(object sender, FormClosingEventArgs e)
        {
            gmnMap.Manager.CancelTileCaching();
        }
    }

    public class GMapPoint : GMapMarker
    {
        public static bool UseIAEAColors;
        public static double MinDoserate;
        public static double MaxDoserate;

        public GMapPoint(PointLatLng pos, Size siz) : base(pos)
        {
            Size = siz;
            Offset = new Point(-Size.Width / 2, -Size.Height / 2);
        }

        public override void OnRender(Graphics g)
        {
            Spectrum spec = Tag as Spectrum;
            Color color = new Color();

            if (UseIAEAColors)
            {
                double dose = spec.Doserate / 1000.0;

                if (dose <= 1.0)
                    color = Color.FromArgb(255, 0, 0, 255);
                else if (dose <= 5.0)
                    color = Color.FromArgb(255, 0, 255, 0);
                else if (dose <= 10.0)
                    color = Color.FromArgb(255, 255, 255, 0);
                else if (dose <= 20.0)
                    color = Color.FromArgb(255, 255, 165, 0);
                else
                    color = Color.FromArgb(255, 255, 0, 0);
            }
            else
            {
                double dose = Math.Log(spec.Doserate);
                color = Utils.MapColor(MinDoserate, MaxDoserate, dose);
            }

            using (SolidBrush brush = new SolidBrush(color))
            {
                g.FillEllipse(brush, LocalPosition.X, LocalPosition.Y, Size.Width, Size.Height);
            }            
        }

        public override void Dispose()
        {
            // Dispose
            base.Dispose();
        }
    }
}
