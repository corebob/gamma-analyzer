﻿/*	
	Crash - Controlling application for Burn
    Copyright (C) 2016  Dag Robole

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

namespace crash
{
    public partial class FormMain : Form
    {
        static ConcurrentQueue<Proto.Message> sendq = new ConcurrentQueue<Proto.Message>();
        static ConcurrentQueue<Proto.Message> recvq = new ConcurrentQueue<Proto.Message>();        

        static NetService netService = new NetService(sendq, recvq);
        static Thread netThread = new Thread(netService.DoWork);

        FormConnect formConnect = new FormConnect();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {            
            lblConnectionStatus.ForeColor = Color.Red;
            lblConnectionStatus.Text = "Not connected";

            netThread.Start();
            while (!netThread.IsAlive);            
                    
            timer.Interval = 10;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            while (!recvq.IsEmpty)
            {
                Proto.Message msg;                
                if (recvq.TryDequeue(out msg))
                    dispatchRecvMsg(msg);                                    
            }            
        }

        private void log(string message)
        {
            tbLog.Text += Environment.NewLine + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ": " + message;
        }        

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            menuItemDisconnect_Click(sender, e);
            Close();
        }

        private void menuItemConnect_Click(object sender, EventArgs e)
        {
            if (formConnect.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            Proto.Message msg = new Proto.Message("connect");
            msg.AddParameter("host", formConnect.IP);
            msg.AddParameter("port", formConnect.Port);            
            sendq.Enqueue(msg);            
        }

        private void menuItemDisconnect_Click(object sender, EventArgs e)
        {            
            sendq.Enqueue(new Proto.Message("disconnect"));
        }

        private void btnSendHello_Click(object sender, EventArgs e)
        {                                    
            sendq.Enqueue(new Proto.Message("ping"));            
        }

        private void btnSendClose_Click(object sender, EventArgs e)
        {            
            sendq.Enqueue(new Proto.Message("close"));                        
        }

        private void btnSendSession_Click(object sender, EventArgs e)
        {            
            sendq.Enqueue(new Proto.Message("new_session"));                                    
        }

        private void btnSendFix_Click(object sender, EventArgs e)
        {            
            sendq.Enqueue(new Proto.Message("fix"));
        }

        private void btnStopNetService_Click(object sender, EventArgs e)
        {
            netService.RequestStop();
            netThread.Join();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(netService.IsRunning())
                btnStopNetService_Click(sender, e);
            timer.Stop();
        }        
    }
}
