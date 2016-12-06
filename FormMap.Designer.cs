﻿namespace crash
{
    partial class FormMap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMap));
            this.toolsMap = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cboxMapProvider = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cboxMapMode = new System.Windows.Forms.ToolStripComboBox();
            this.btnGoToLatLon = new System.Windows.Forms.ToolStripButton();
            this.btnZoomToMin = new System.Windows.Forms.ToolStripButton();
            this.btnZoomIn = new System.Windows.Forms.ToolStripButton();
            this.btnZoomOut = new System.Windows.Forms.ToolStripButton();
            this.btnZoomToMax = new System.Windows.Forms.ToolStripButton();
            this.status = new System.Windows.Forms.StatusStrip();
            this.gmnMap = new GMap.NET.WindowsForms.GMapControl();
            this.toolsMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolsMap
            // 
            this.toolsMap.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolsMap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.cboxMapProvider,
            this.toolStripLabel1,
            this.cboxMapMode,
            this.btnGoToLatLon,
            this.btnZoomToMin,
            this.btnZoomIn,
            this.btnZoomOut,
            this.btnZoomToMax});
            this.toolsMap.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolsMap.Location = new System.Drawing.Point(0, 0);
            this.toolsMap.Name = "toolsMap";
            this.toolsMap.Size = new System.Drawing.Size(851, 25);
            this.toolsMap.TabIndex = 4;
            this.toolsMap.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(51, 22);
            this.toolStripLabel2.Text = "Provider";
            // 
            // cboxMapProvider
            // 
            this.cboxMapProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMapProvider.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cboxMapProvider.Items.AddRange(new object[] {
            "Google Map",
            "Google Map Terrain",
            "Google Map Sattelite",
            "Open Street Map",
            "Open Street Map Quest",
            "ArcGIS World Topo",
            "ArcGIS World 2D",
            "ArcGIS World Shaded",
            "Bing Map",
            "Bing Map Hybrid",
            "Bing Map Satellite",
            "Yahoo Map",
            "Yahoo Map Hybrid",
            "Yahoo Map Satellite"});
            this.cboxMapProvider.Name = "cboxMapProvider";
            this.cboxMapProvider.Size = new System.Drawing.Size(120, 25);
            this.cboxMapProvider.SelectedIndexChanged += new System.EventHandler(this.cboxMapProvider_SelectedIndexChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(38, 22);
            this.toolStripLabel1.Text = "Mode";
            // 
            // cboxMapMode
            // 
            this.cboxMapMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMapMode.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cboxMapMode.Items.AddRange(new object[] {
            "Server",
            "Cache",
            "Server and Cache"});
            this.cboxMapMode.Name = "cboxMapMode";
            this.cboxMapMode.Size = new System.Drawing.Size(105, 25);
            this.cboxMapMode.SelectedIndexChanged += new System.EventHandler(this.cboxMapMode_SelectedIndexChanged);
            // 
            // btnGoToLatLon
            // 
            this.btnGoToLatLon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoToLatLon.Name = "btnGoToLatLon";
            this.btnGoToLatLon.Size = new System.Drawing.Size(49, 22);
            this.btnGoToLatLon.Text = "Go to...";
            this.btnGoToLatLon.Click += new System.EventHandler(this.btnGoToLatLon_Click);
            // 
            // btnZoomToMin
            // 
            this.btnZoomToMin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnZoomToMin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomToMin.Image = global::crash.Properties.Resources.right_all_16;
            this.btnZoomToMin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomToMin.Name = "btnZoomToMin";
            this.btnZoomToMin.Size = new System.Drawing.Size(23, 22);
            this.btnZoomToMin.Text = "toolStripButton4";
            this.btnZoomToMin.Click += new System.EventHandler(this.btnZoomToMin_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomIn.Image = global::crash.Properties.Resources.right_16;
            this.btnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(23, 22);
            this.btnZoomIn.Text = "toolStripButton3";
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomOut.Image = global::crash.Properties.Resources.left_16;
            this.btnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(23, 22);
            this.btnZoomOut.Text = "toolStripButton2";
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomToMax
            // 
            this.btnZoomToMax.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnZoomToMax.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomToMax.Image = global::crash.Properties.Resources.left_all_16;
            this.btnZoomToMax.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomToMax.Name = "btnZoomToMax";
            this.btnZoomToMax.Size = new System.Drawing.Size(23, 22);
            this.btnZoomToMax.Text = "toolStripButton1";
            this.btnZoomToMax.Click += new System.EventHandler(this.btnZoomToMax_Click);
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(0, 586);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(851, 22);
            this.status.TabIndex = 6;
            this.status.Text = "statusStrip1";
            // 
            // gmnMap
            // 
            this.gmnMap.Bearing = 0F;
            this.gmnMap.CanDragMap = true;
            this.gmnMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmnMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmnMap.GrayScaleMode = false;
            this.gmnMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmnMap.LevelsKeepInMemmory = 5;
            this.gmnMap.Location = new System.Drawing.Point(0, 25);
            this.gmnMap.MarkersEnabled = true;
            this.gmnMap.MaxZoom = 24;
            this.gmnMap.MinZoom = 2;
            this.gmnMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmnMap.Name = "gmnMap";
            this.gmnMap.NegativeMode = false;
            this.gmnMap.PolygonsEnabled = true;
            this.gmnMap.RetryLoadTile = 0;
            this.gmnMap.RoutesEnabled = true;
            this.gmnMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmnMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmnMap.ShowTileGridLines = false;
            this.gmnMap.Size = new System.Drawing.Size(851, 561);
            this.gmnMap.TabIndex = 7;
            this.gmnMap.Zoom = 10D;
            this.gmnMap.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gmap_OnMarkerClick);
            // 
            // FormMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 608);
            this.Controls.Add(this.gmnMap);
            this.Controls.Add(this.status);
            this.Controls.Add(this.toolsMap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(320, 200);
            this.Name = "FormMap";
            this.Text = "Gamma Analyzer - Map";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMap_FormClosing);
            this.Load += new System.EventHandler(this.FormMap_Load);
            this.toolsMap.ResumeLayout(false);
            this.toolsMap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolsMap;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cboxMapProvider;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cboxMapMode;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripButton btnGoToLatLon;
        private System.Windows.Forms.ToolStripButton btnZoomToMax;
        private System.Windows.Forms.ToolStripButton btnZoomOut;
        private System.Windows.Forms.ToolStripButton btnZoomIn;
        private System.Windows.Forms.ToolStripButton btnZoomToMin;
        private GMap.NET.WindowsForms.GMapControl gmnMap;
    }
}