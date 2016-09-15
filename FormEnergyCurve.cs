﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace crash
{
    public partial class FormEnergyCurve : Form
    {
        private List<double> CoeffList = null;
        private Detector Det;

        public FormEnergyCurve(Detector detector, List<double> coeffList)
        {
            InitializeComponent();
            CoeffList = coeffList;
            Det = detector;
        }

        private void FormEnergyCurve_Load(object sender, EventArgs e)
        {
            if (CoeffList.Count < 2)
                return;

            string curveName = "";
            int counter = 0;
            foreach (double coeff in CoeffList)
            {
                curveName += coeff.ToString("E") + " * x^" + counter.ToString() + " + ";
                counter++;
            }
            curveName = curveName.Substring(0, curveName.Length - 3);

            GraphPane pane = graph.GraphPane;
            int w = (int)(pane.Rect.Right - pane.Rect.Left);            
            PointPairList list = new PointPairList();
            for (int i = 0; i < w; i++)            
                list.Add((double)i, Det.GetEnergy(i));            

            LineItem energyCurve = pane.AddCurve(curveName, list, Color.Green, SymbolType.None);

            graph.RestoreScale(pane);
            graph.AxisChange();
            graph.Refresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }
    }
}