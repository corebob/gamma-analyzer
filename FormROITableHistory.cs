﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crash
{
    public partial class FormROITableHistory : Form
    {
        Session session = null;
        Bitmap bmpPane = null;
        List<ROIData> roiList = new List<ROIData>();

        public FormROITableHistory()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void FormROITableHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void FormROITableHistory_Load(object sender, EventArgs e)
        {
            pane_Resize(sender, e);
        }

        public void SetSession(Session sess)
        {
            session = sess;
        }

        public void UpdatePane()
        {
            if (session == null || bmpPane == null || WindowState == FormWindowState.Minimized)
                return;

            if (session.Spectrums.Count < 1)
                return;

            if (roiList.Count < 1)
                return;

            Graphics g = Graphics.FromImage(bmpPane);
            g.Clear(SystemColors.ButtonFace);
            
            float scaling = -1f;

            foreach (ROIData rd in roiList)
            {
                if (!rd.Active)
                    continue;                                

                float s = (pane.Height - 40) / session.GetMaxCountInROI((int)rd.StartChannel, (int)rd.EndChannel);

                if(scaling == -1f)
                {
                    scaling = s;
                }
                else
                {
                    if (s < scaling)
                        scaling = s;
                }
            }

            lblScaling.Text = scaling.ToString();

            foreach(ROIData rd in roiList)
            {
                if (!rd.Active)
                    continue;

                Pen pen = new Pen(rd.Color, 2);
                int x = 0;
                int last_x = 0, last_y = pane.Height - 40;                

                foreach (Spectrum s in session.Spectrums)
                {
                    float weightedCount = s.GetCountInROI((int)rd.StartChannel, (int)rd.EndChannel) * scaling;
                    int y = pane.Height - 40 - (int)weightedCount;

                    if (x >= 0 && x < pane.Width && y >= 0 && y < pane.Height)
                    {
                        g.DrawLine(pen, last_x, last_y, x, y);
                    }
                    last_x = x;
                    last_y = y;
                    x++;

                    if ((x % 50) == 0)
                    {
                        FontFamily fontFamily = new FontFamily("Arial");
                        Font font = new Font(fontFamily, 10, FontStyle.Regular, GraphicsUnit.Pixel);
                        g.DrawString(weightedCount.ToString(), font, new SolidBrush(rd.Color), x, pane.Height - 20);
                    }
                }
            }

            pane.Refresh();
        }

        private void pane_Paint(object sender, PaintEventArgs e)
        {
            if (bmpPane == null || WindowState == FormWindowState.Minimized)
                return;

            e.Graphics.DrawImage(bmpPane, 0, 0);
        }

        private void pane_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                return;
            if (pane.Width < 1 || pane.Height < 1)
                return;

            bmpPane = new Bitmap(pane.Width, pane.Height);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            roiList.Clear();

            Color[] colorList = { Color.Red, Color.Blue, Color.Green, Color.Orange, Color.Cyan };
            int colorIndex = 0;

            foreach(DataGridViewRow row in gridROI.Rows)
            {
                if(row.Cells[0].Value == null
                    || row.Cells[1].Value == null
                    || row.Cells[2].Value == null
                    || row.Cells[3].Value == null)
                {
                    continue;
                }

                ROIData rd = new ROIData();
                rd.Name = row.Cells[0].Value.ToString();
                rd.StartChannel = Convert.ToSingle(row.Cells[1].Value);
                rd.EndChannel = Convert.ToSingle(row.Cells[2].Value);
                rd.Active = Convert.ToBoolean(row.Cells[3].Value);
                rd.Color = colorList[colorIndex];
                roiList.Add(rd);
                colorIndex++;
                row.Cells[4].Value = rd.Color.ToString();
            }
        }
    }

    public class ROIData
    {
        public string Name { get; set; }
        public float StartChannel { get; set; }
        public float EndChannel { get; set; }
        public bool Active { get; set; }
        public Color Color { get; set; }
    }
}