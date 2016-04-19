﻿namespace crash
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPreferences = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSession = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLoadSession = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLoadBackgroundSession = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSaveCHN = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSaveIrix = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tools = new System.Windows.Forms.ToolStrip();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPreferences = new System.Windows.Forms.ToolStripButton();
            this.btnShowLog = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConnect = new System.Windows.Forms.ToolStripButton();
            this.btnDisconnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnShowMap = new System.Windows.Forms.ToolStripButton();
            this.btnShowWaterfallLive = new System.Windows.Forms.ToolStripButton();
            this.lblInterface = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lblConnectionStatus = new System.Windows.Forms.ToolStripLabel();
            this.btnShowWaterfallHist = new System.Windows.Forms.ToolStripButton();
            this.btnShowROIChart = new System.Windows.Forms.ToolStripButton();
            this.btnShow3D = new System.Windows.Forms.ToolStripButton();
            this.btnShowDoserate = new System.Windows.Forms.ToolStripButton();
            this.tabs = new TabControlWizard.TabControlWizard();
            this.pageSetup = new System.Windows.Forms.TabPage();
            this.graphSetup = new ZedGraph.ZedGraphControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSetupVoltage = new System.Windows.Forms.TextBox();
            this.tbSetupCoarseGain = new System.Windows.Forms.TextBox();
            this.tbSetupFineGain = new System.Windows.Forms.TextBox();
            this.cboxSetupDetector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxSetupChannels = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSetupLLD = new System.Windows.Forms.TextBox();
            this.tbSetupULD = new System.Windows.Forms.TextBox();
            this.tbSetupLivetime = new System.Windows.Forms.TextBox();
            this.btnSetupStoreParams = new System.Windows.Forms.Button();
            this.btnSetupSetParams = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSetupStop = new System.Windows.Forms.Button();
            this.btnSetupStart = new System.Windows.Forms.Button();
            this.lblSetupDoserate = new System.Windows.Forms.Label();
            this.pageMenu = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMenuSetup = new System.Windows.Forms.Button();
            this.btnMenuSession = new System.Windows.Forms.Button();
            this.pageSession = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lbSession = new System.Windows.Forms.ListBox();
            this.graphSession = new ZedGraph.ZedGraphControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblLatitudeStart = new System.Windows.Forms.Label();
            this.lblLongitudeStart = new System.Windows.Forms.Label();
            this.lblRealtime = new System.Windows.Forms.Label();
            this.lblLivetime = new System.Windows.Forms.Label();
            this.lblSession = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.lblAltitudeStart = new System.Windows.Forms.Label();
            this.lblMaxCount = new System.Windows.Forms.Label();
            this.lblMinCount = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.lblGpsTimeStart = new System.Windows.Forms.Label();
            this.lblLatitudeEnd = new System.Windows.Forms.Label();
            this.lblLongitudeEnd = new System.Windows.Forms.Label();
            this.lblAltitudeEnd = new System.Windows.Forms.Label();
            this.lblGpsTimeEnd = new System.Windows.Forms.Label();
            this.lblDoserate = new System.Windows.Forms.Label();
            this.tblSession = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSpecCount = new System.Windows.Forms.TextBox();
            this.tbSpecLivetime = new System.Windows.Forms.TextBox();
            this.tbSpecDelay = new System.Windows.Forms.TextBox();
            this.btnSendSession = new System.Windows.Forms.Button();
            this.btnStopSession = new System.Windows.Forms.Button();
            this.btnSendClose = new System.Windows.Forms.Button();
            this.cbStoreChn = new System.Windows.Forms.CheckBox();
            this.menu.SuspendLayout();
            this.status.SuspendLayout();
            this.tools.SuspendLayout();
            this.tabs.SuspendLayout();
            this.pageSetup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pageMenu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pageSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tblSession.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.menuItemEdit,
            this.menuItemSession,
            this.menuItemHelp});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(1208, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemConnect,
            this.menuItemDisconnect,
            this.toolStripSeparator1,
            this.menuItemExit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(37, 20);
            this.menuItemFile.Text = "&File";
            // 
            // menuItemConnect
            // 
            this.menuItemConnect.Name = "menuItemConnect";
            this.menuItemConnect.Size = new System.Drawing.Size(133, 22);
            this.menuItemConnect.Text = "&Connect";
            this.menuItemConnect.Click += new System.EventHandler(this.menuItemConnect_Click);
            // 
            // menuItemDisconnect
            // 
            this.menuItemDisconnect.Name = "menuItemDisconnect";
            this.menuItemDisconnect.Size = new System.Drawing.Size(133, 22);
            this.menuItemDisconnect.Text = "&Disconnect";
            this.menuItemDisconnect.Click += new System.EventHandler(this.menuItemDisconnect_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(133, 22);
            this.menuItemExit.Text = "E&xit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuItemEdit
            // 
            this.menuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemPreferences});
            this.menuItemEdit.Name = "menuItemEdit";
            this.menuItemEdit.Size = new System.Drawing.Size(39, 20);
            this.menuItemEdit.Text = "&Edit";
            // 
            // menuItemPreferences
            // 
            this.menuItemPreferences.Name = "menuItemPreferences";
            this.menuItemPreferences.Size = new System.Drawing.Size(135, 22);
            this.menuItemPreferences.Text = "&Preferences";
            this.menuItemPreferences.Click += new System.EventHandler(this.menuItemPreferences_Click);
            // 
            // menuItemSession
            // 
            this.menuItemSession.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemLoadSession,
            this.menuItemLoadBackgroundSession,
            this.menuItemSaveCHN,
            this.menuItemSaveIrix});
            this.menuItemSession.Name = "menuItemSession";
            this.menuItemSession.Size = new System.Drawing.Size(58, 20);
            this.menuItemSession.Text = "&Session";
            // 
            // menuItemLoadSession
            // 
            this.menuItemLoadSession.Name = "menuItemLoadSession";
            this.menuItemLoadSession.Size = new System.Drawing.Size(208, 22);
            this.menuItemLoadSession.Text = "Load &existing session";
            this.menuItemLoadSession.Click += new System.EventHandler(this.menuItemLoadSession_Click);
            // 
            // menuItemLoadBackgroundSession
            // 
            this.menuItemLoadBackgroundSession.Name = "menuItemLoadBackgroundSession";
            this.menuItemLoadBackgroundSession.Size = new System.Drawing.Size(208, 22);
            this.menuItemLoadBackgroundSession.Text = "Load &background session";
            this.menuItemLoadBackgroundSession.Click += new System.EventHandler(this.menuItemLoadBackgroundSession_Click);
            // 
            // menuItemSaveCHN
            // 
            this.menuItemSaveCHN.Name = "menuItemSaveCHN";
            this.menuItemSaveCHN.Size = new System.Drawing.Size(208, 22);
            this.menuItemSaveCHN.Text = "Save as &CHN";
            this.menuItemSaveCHN.Click += new System.EventHandler(this.menuItemSaveCHN_Click);
            // 
            // menuItemSaveIrix
            // 
            this.menuItemSaveIrix.Name = "menuItemSaveIrix";
            this.menuItemSaveIrix.Size = new System.Drawing.Size(208, 22);
            this.menuItemSaveIrix.Text = "Save as &Irix";
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAbout});
            this.menuItemHelp.Name = "menuItemHelp";
            this.menuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.menuItemHelp.Text = "&Help";
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Size = new System.Drawing.Size(107, 22);
            this.menuItemAbout.Text = "&About";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.status.Location = new System.Drawing.Point(0, 727);
            this.status.Name = "status";
            this.status.Padding = new System.Windows.Forms.Padding(1, 0, 17, 0);
            this.status.Size = new System.Drawing.Size(1208, 22);
            this.status.TabIndex = 1;
            this.status.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // tools
            // 
            this.tools.AutoSize = false;
            this.tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.toolStripSeparator2,
            this.btnPreferences,
            this.btnShowLog,
            this.toolStripSeparator5,
            this.btnConnect,
            this.btnDisconnect,
            this.toolStripSeparator3,
            this.btnShowMap,
            this.btnShowWaterfallLive,
            this.lblInterface,
            this.toolStripSeparator4,
            this.lblConnectionStatus,
            this.btnShowWaterfallHist,
            this.btnShowROIChart,
            this.btnShow3D,
            this.btnShowDoserate});
            this.tools.Location = new System.Drawing.Point(0, 24);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(1208, 40);
            this.tools.TabIndex = 2;
            this.tools.Text = "toolStrip1";
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = false;
            this.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBack.Image = global::crash.Properties.Resources.home_32;
            this.btnBack.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(38, 38);
            this.btnBack.Text = "toolStripButton1";
            this.btnBack.ToolTipText = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // btnPreferences
            // 
            this.btnPreferences.AutoSize = false;
            this.btnPreferences.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPreferences.Image = global::crash.Properties.Resources.settings_32;
            this.btnPreferences.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPreferences.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPreferences.Name = "btnPreferences";
            this.btnPreferences.Size = new System.Drawing.Size(38, 38);
            this.btnPreferences.Text = "toolStripButton1";
            this.btnPreferences.ToolTipText = "Open preferences";
            this.btnPreferences.Click += new System.EventHandler(this.menuItemPreferences_Click);
            // 
            // btnShowLog
            // 
            this.btnShowLog.AutoSize = false;
            this.btnShowLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShowLog.Image = global::crash.Properties.Resources.log_32;
            this.btnShowLog.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnShowLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowLog.Name = "btnShowLog";
            this.btnShowLog.Size = new System.Drawing.Size(38, 38);
            this.btnShowLog.Text = "toolStripButton1";
            this.btnShowLog.ToolTipText = "Show log";
            this.btnShowLog.Click += new System.EventHandler(this.btnShowLog_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 40);
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSize = false;
            this.btnConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConnect.Image = global::crash.Properties.Resources.connect_32;
            this.btnConnect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(38, 38);
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.menuItemConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.AutoSize = false;
            this.btnDisconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDisconnect.Image = global::crash.Properties.Resources.disconnect_32;
            this.btnDisconnect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(38, 38);
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.Click += new System.EventHandler(this.menuItemDisconnect_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 40);
            // 
            // btnShowMap
            // 
            this.btnShowMap.AutoSize = false;
            this.btnShowMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShowMap.Image = global::crash.Properties.Resources.map_32;
            this.btnShowMap.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnShowMap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowMap.Name = "btnShowMap";
            this.btnShowMap.Size = new System.Drawing.Size(38, 38);
            this.btnShowMap.Text = "toolStripButton2";
            this.btnShowMap.ToolTipText = "Show map";
            this.btnShowMap.Click += new System.EventHandler(this.btnShowMap_Click);
            // 
            // btnShowWaterfallLive
            // 
            this.btnShowWaterfallLive.AutoSize = false;
            this.btnShowWaterfallLive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShowWaterfallLive.Image = global::crash.Properties.Resources.waterfall_live_32;
            this.btnShowWaterfallLive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnShowWaterfallLive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowWaterfallLive.Name = "btnShowWaterfallLive";
            this.btnShowWaterfallLive.Size = new System.Drawing.Size(38, 38);
            this.btnShowWaterfallLive.Text = "toolStripButton2";
            this.btnShowWaterfallLive.ToolTipText = "Show waterfall live";
            this.btnShowWaterfallLive.Click += new System.EventHandler(this.btnShowWaterfall_Click);
            // 
            // lblInterface
            // 
            this.lblInterface.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblInterface.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblInterface.Name = "lblInterface";
            this.lblInterface.Size = new System.Drawing.Size(88, 37);
            this.lblInterface.Text = "<lblInterface>";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 40);
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(130, 37);
            this.lblConnectionStatus.Text = "<lblConnectionStatus>";
            // 
            // btnShowWaterfallHist
            // 
            this.btnShowWaterfallHist.AutoSize = false;
            this.btnShowWaterfallHist.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShowWaterfallHist.Image = global::crash.Properties.Resources.waterfall_history_32;
            this.btnShowWaterfallHist.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnShowWaterfallHist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowWaterfallHist.Name = "btnShowWaterfallHist";
            this.btnShowWaterfallHist.Size = new System.Drawing.Size(38, 38);
            this.btnShowWaterfallHist.Text = "toolStripButton1";
            this.btnShowWaterfallHist.ToolTipText = "Show waterfall history";
            this.btnShowWaterfallHist.Click += new System.EventHandler(this.btnShowWaterfallHist_Click);
            // 
            // btnShowROIChart
            // 
            this.btnShowROIChart.AutoSize = false;
            this.btnShowROIChart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShowROIChart.Image = global::crash.Properties.Resources.roitable_history_32;
            this.btnShowROIChart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnShowROIChart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowROIChart.Name = "btnShowROIChart";
            this.btnShowROIChart.Size = new System.Drawing.Size(38, 38);
            this.btnShowROIChart.Text = "toolStripButton1";
            this.btnShowROIChart.ToolTipText = "Show ROI history";
            this.btnShowROIChart.Click += new System.EventHandler(this.btnShowROIChart_Click);
            // 
            // btnShow3D
            // 
            this.btnShow3D.AutoSize = false;
            this.btnShow3D.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShow3D.Enabled = false;
            this.btnShow3D.Image = global::crash.Properties.Resources._3D_32;
            this.btnShow3D.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnShow3D.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShow3D.Name = "btnShow3D";
            this.btnShow3D.Size = new System.Drawing.Size(38, 38);
            this.btnShow3D.Text = "toolStripButton1";
            this.btnShow3D.ToolTipText = "Show 3D session";
            this.btnShow3D.Click += new System.EventHandler(this.btnShow3D_Click);
            // 
            // btnShowDoserate
            // 
            this.btnShowDoserate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShowDoserate.Image = ((System.Drawing.Image)(resources.GetObject("btnShowDoserate.Image")));
            this.btnShowDoserate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowDoserate.Name = "btnShowDoserate";
            this.btnShowDoserate.Size = new System.Drawing.Size(23, 37);
            this.btnShowDoserate.Text = "toolStripButton1";
            this.btnShowDoserate.ToolTipText = "Show doserate";
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.pageSetup);
            this.tabs.Controls.Add(this.pageMenu);
            this.tabs.Controls.Add(this.pageSession);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 64);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1208, 663);
            this.tabs.TabIndex = 4;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // pageSetup
            // 
            this.pageSetup.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pageSetup.Controls.Add(this.graphSetup);
            this.pageSetup.Controls.Add(this.tableLayoutPanel1);
            this.pageSetup.Location = new System.Drawing.Point(4, 25);
            this.pageSetup.Name = "pageSetup";
            this.pageSetup.Padding = new System.Windows.Forms.Padding(3);
            this.pageSetup.Size = new System.Drawing.Size(1200, 634);
            this.pageSetup.TabIndex = 0;
            this.pageSetup.Text = "Setup";
            // 
            // graphSetup
            // 
            this.graphSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphSetup.IsShowPointValues = true;
            this.graphSetup.Location = new System.Drawing.Point(3, 182);
            this.graphSetup.Name = "graphSetup";
            this.graphSetup.ScrollGrace = 0D;
            this.graphSetup.ScrollMaxX = 0D;
            this.graphSetup.ScrollMaxY = 0D;
            this.graphSetup.ScrollMaxY2 = 0D;
            this.graphSetup.ScrollMinX = 0D;
            this.graphSetup.ScrollMinY = 0D;
            this.graphSetup.ScrollMinY2 = 0D;
            this.graphSetup.Size = new System.Drawing.Size(1194, 449);
            this.graphSetup.TabIndex = 21;
            this.graphSetup.UseExtendedPrintDialog = true;
            this.graphSetup.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.graphSetup_MouseDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbSetupVoltage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbSetupCoarseGain, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbSetupFineGain, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboxSetupDetector, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboxSetupChannels, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbSetupLLD, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbSetupULD, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbSetupLivetime, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSetupStoreParams, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSetupSetParams, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblSetupDoserate, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1194, 179);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Voltage, Coarse gain, Fine gain";
            // 
            // tbSetupVoltage
            // 
            this.tbSetupVoltage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSetupVoltage.Location = new System.Drawing.Point(301, 31);
            this.tbSetupVoltage.Name = "tbSetupVoltage";
            this.tbSetupVoltage.Size = new System.Drawing.Size(292, 21);
            this.tbSetupVoltage.TabIndex = 13;
            // 
            // tbSetupCoarseGain
            // 
            this.tbSetupCoarseGain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSetupCoarseGain.Location = new System.Drawing.Point(599, 31);
            this.tbSetupCoarseGain.Name = "tbSetupCoarseGain";
            this.tbSetupCoarseGain.Size = new System.Drawing.Size(292, 21);
            this.tbSetupCoarseGain.TabIndex = 14;
            // 
            // tbSetupFineGain
            // 
            this.tbSetupFineGain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSetupFineGain.Location = new System.Drawing.Point(897, 31);
            this.tbSetupFineGain.Name = "tbSetupFineGain";
            this.tbSetupFineGain.Size = new System.Drawing.Size(294, 21);
            this.tbSetupFineGain.TabIndex = 15;
            // 
            // cboxSetupDetector
            // 
            this.cboxSetupDetector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxSetupDetector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSetupDetector.FormattingEnabled = true;
            this.cboxSetupDetector.Location = new System.Drawing.Point(301, 3);
            this.cboxSetupDetector.Name = "cboxSetupDetector";
            this.cboxSetupDetector.Size = new System.Drawing.Size(292, 23);
            this.cboxSetupDetector.TabIndex = 17;
            this.cboxSetupDetector.SelectedValueChanged += new System.EventHandler(this.cboxSetupDetector_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Detector, Channels";
            // 
            // cboxSetupChannels
            // 
            this.cboxSetupChannels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxSetupChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSetupChannels.FormattingEnabled = true;
            this.cboxSetupChannels.Location = new System.Drawing.Point(599, 3);
            this.cboxSetupChannels.Name = "cboxSetupChannels";
            this.cboxSetupChannels.Size = new System.Drawing.Size(292, 23);
            this.cboxSetupChannels.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "LLD, ULD, Livetime";
            // 
            // tbSetupLLD
            // 
            this.tbSetupLLD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSetupLLD.Location = new System.Drawing.Point(301, 59);
            this.tbSetupLLD.Name = "tbSetupLLD";
            this.tbSetupLLD.Size = new System.Drawing.Size(292, 21);
            this.tbSetupLLD.TabIndex = 22;
            // 
            // tbSetupULD
            // 
            this.tbSetupULD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSetupULD.Location = new System.Drawing.Point(599, 59);
            this.tbSetupULD.Name = "tbSetupULD";
            this.tbSetupULD.Size = new System.Drawing.Size(292, 21);
            this.tbSetupULD.TabIndex = 23;
            // 
            // tbSetupLivetime
            // 
            this.tbSetupLivetime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSetupLivetime.Location = new System.Drawing.Point(897, 59);
            this.tbSetupLivetime.Name = "tbSetupLivetime";
            this.tbSetupLivetime.Size = new System.Drawing.Size(294, 21);
            this.tbSetupLivetime.TabIndex = 24;
            // 
            // btnSetupStoreParams
            // 
            this.btnSetupStoreParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetupStoreParams.Location = new System.Drawing.Point(897, 87);
            this.btnSetupStoreParams.Name = "btnSetupStoreParams";
            this.btnSetupStoreParams.Size = new System.Drawing.Size(294, 22);
            this.btnSetupStoreParams.TabIndex = 27;
            this.btnSetupStoreParams.Text = "Store parameters in settings";
            this.btnSetupStoreParams.UseVisualStyleBackColor = true;
            this.btnSetupStoreParams.Click += new System.EventHandler(this.btnSetupStoreParams_Click);
            // 
            // btnSetupSetParams
            // 
            this.btnSetupSetParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetupSetParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetupSetParams.Location = new System.Drawing.Point(599, 87);
            this.btnSetupSetParams.Name = "btnSetupSetParams";
            this.btnSetupSetParams.Size = new System.Drawing.Size(292, 22);
            this.btnSetupSetParams.TabIndex = 16;
            this.btnSetupSetParams.Text = "Send detector parameters";
            this.btnSetupSetParams.UseVisualStyleBackColor = true;
            this.btnSetupSetParams.Click += new System.EventHandler(this.btnSetupSetParams_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSetupStop);
            this.panel1.Controls.Add(this.btnSetupStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(897, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 22);
            this.panel1.TabIndex = 28;
            // 
            // btnSetupStop
            // 
            this.btnSetupStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetupStop.Location = new System.Drawing.Point(141, 0);
            this.btnSetupStop.Name = "btnSetupStop";
            this.btnSetupStop.Size = new System.Drawing.Size(153, 22);
            this.btnSetupStop.TabIndex = 25;
            this.btnSetupStop.Text = "Stop";
            this.btnSetupStop.UseVisualStyleBackColor = true;
            this.btnSetupStop.Click += new System.EventHandler(this.btnSetupStop_Click);
            // 
            // btnSetupStart
            // 
            this.btnSetupStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSetupStart.Location = new System.Drawing.Point(0, 0);
            this.btnSetupStart.Name = "btnSetupStart";
            this.btnSetupStart.Size = new System.Drawing.Size(141, 22);
            this.btnSetupStart.TabIndex = 26;
            this.btnSetupStart.Text = "Start";
            this.btnSetupStart.UseVisualStyleBackColor = true;
            this.btnSetupStart.Click += new System.EventHandler(this.btnSetupStart_Click);
            // 
            // lblSetupDoserate
            // 
            this.lblSetupDoserate.AutoSize = true;
            this.lblSetupDoserate.Location = new System.Drawing.Point(3, 140);
            this.lblSetupDoserate.Name = "lblSetupDoserate";
            this.lblSetupDoserate.Size = new System.Drawing.Size(71, 15);
            this.lblSetupDoserate.TabIndex = 29;
            this.lblSetupDoserate.Text = "<Doserate>";
            // 
            // pageMenu
            // 
            this.pageMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pageMenu.Controls.Add(this.flowLayoutPanel1);
            this.pageMenu.Location = new System.Drawing.Point(4, 25);
            this.pageMenu.Name = "pageMenu";
            this.pageMenu.Padding = new System.Windows.Forms.Padding(3);
            this.pageMenu.Size = new System.Drawing.Size(1200, 634);
            this.pageMenu.TabIndex = 1;
            this.pageMenu.Text = "Menu";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnMenuSetup);
            this.flowLayoutPanel1.Controls.Add(this.btnMenuSession);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(44, 47, 44, 47);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1194, 628);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnMenuSetup
            // 
            this.btnMenuSetup.FlatAppearance.BorderSize = 0;
            this.btnMenuSetup.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuSetup.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuSetup.Image = global::crash.Properties.Resources.setup_128;
            this.btnMenuSetup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMenuSetup.Location = new System.Drawing.Point(47, 50);
            this.btnMenuSetup.Name = "btnMenuSetup";
            this.btnMenuSetup.Size = new System.Drawing.Size(160, 170);
            this.btnMenuSetup.TabIndex = 0;
            this.btnMenuSetup.Text = "Calibrate";
            this.btnMenuSetup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenuSetup.UseVisualStyleBackColor = true;
            this.btnMenuSetup.Click += new System.EventHandler(this.btnMenuSpec_Click);
            // 
            // btnMenuSession
            // 
            this.btnMenuSession.FlatAppearance.BorderSize = 0;
            this.btnMenuSession.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuSession.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuSession.Image = global::crash.Properties.Resources.map_128;
            this.btnMenuSession.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMenuSession.Location = new System.Drawing.Point(213, 50);
            this.btnMenuSession.Name = "btnMenuSession";
            this.btnMenuSession.Size = new System.Drawing.Size(160, 170);
            this.btnMenuSession.TabIndex = 2;
            this.btnMenuSession.Text = "Sessions";
            this.btnMenuSession.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenuSession.UseVisualStyleBackColor = true;
            this.btnMenuSession.Click += new System.EventHandler(this.btnMenuSession_Click);
            // 
            // pageSession
            // 
            this.pageSession.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pageSession.Controls.Add(this.splitContainer2);
            this.pageSession.Controls.Add(this.tblSession);
            this.pageSession.Location = new System.Drawing.Point(4, 25);
            this.pageSession.Name = "pageSession";
            this.pageSession.Padding = new System.Windows.Forms.Padding(3);
            this.pageSession.Size = new System.Drawing.Size(1200, 634);
            this.pageSession.TabIndex = 2;
            this.pageSession.Text = "Session";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 76);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lbSession);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.graphSession);
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer2.Size = new System.Drawing.Size(1194, 555);
            this.splitContainer2.SplitterDistance = 202;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 6;
            // 
            // lbSession
            // 
            this.lbSession.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbSession.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbSession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSession.FormattingEnabled = true;
            this.lbSession.ItemHeight = 15;
            this.lbSession.Location = new System.Drawing.Point(0, 0);
            this.lbSession.Name = "lbSession";
            this.lbSession.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbSession.Size = new System.Drawing.Size(200, 553);
            this.lbSession.TabIndex = 7;
            this.lbSession.SelectedIndexChanged += new System.EventHandler(this.lbSession_SelectedIndexChanged);
            // 
            // graphSession
            // 
            this.graphSession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphSession.IsShowPointValues = true;
            this.graphSession.Location = new System.Drawing.Point(0, 91);
            this.graphSession.Name = "graphSession";
            this.graphSession.ScrollGrace = 0D;
            this.graphSession.ScrollMaxX = 0D;
            this.graphSession.ScrollMaxY = 0D;
            this.graphSession.ScrollMaxY2 = 0D;
            this.graphSession.ScrollMinX = 0D;
            this.graphSession.ScrollMinY = 0D;
            this.graphSession.ScrollMinY2 = 0D;
            this.graphSession.Size = new System.Drawing.Size(985, 462);
            this.graphSession.TabIndex = 5;
            this.graphSession.UseExtendedPrintDialog = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.lblLatitudeStart, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblLongitudeStart, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblRealtime, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblLivetime, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSession, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblIndex, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblAltitudeStart, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblMaxCount, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblMinCount, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblTotalCount, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblGpsTimeStart, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblLatitudeEnd, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblLongitudeEnd, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblAltitudeEnd, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblGpsTimeEnd, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblDoserate, 3, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(985, 91);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblLatitudeStart
            // 
            this.lblLatitudeStart.AutoSize = true;
            this.lblLatitudeStart.Location = new System.Drawing.Point(3, 20);
            this.lblLatitudeStart.Name = "lblLatitudeStart";
            this.lblLatitudeStart.Size = new System.Drawing.Size(90, 15);
            this.lblLatitudeStart.TabIndex = 0;
            this.lblLatitudeStart.Text = "<LatitudeStart>";
            // 
            // lblLongitudeStart
            // 
            this.lblLongitudeStart.AutoSize = true;
            this.lblLongitudeStart.Location = new System.Drawing.Point(249, 20);
            this.lblLongitudeStart.Name = "lblLongitudeStart";
            this.lblLongitudeStart.Size = new System.Drawing.Size(101, 15);
            this.lblLongitudeStart.TabIndex = 1;
            this.lblLongitudeStart.Text = "<LongitudeStart>";
            // 
            // lblRealtime
            // 
            this.lblRealtime.AutoSize = true;
            this.lblRealtime.Location = new System.Drawing.Point(3, 0);
            this.lblRealtime.Name = "lblRealtime";
            this.lblRealtime.Size = new System.Drawing.Size(71, 15);
            this.lblRealtime.TabIndex = 2;
            this.lblRealtime.Text = "<Realtime>";
            // 
            // lblLivetime
            // 
            this.lblLivetime.AutoSize = true;
            this.lblLivetime.Location = new System.Drawing.Point(249, 0);
            this.lblLivetime.Name = "lblLivetime";
            this.lblLivetime.Size = new System.Drawing.Size(67, 15);
            this.lblLivetime.TabIndex = 3;
            this.lblLivetime.Text = "<Livetime>";
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Location = new System.Drawing.Point(495, 0);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(65, 15);
            this.lblSession.TabIndex = 4;
            this.lblSession.Text = "<Session>";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(741, 0);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(51, 15);
            this.lblIndex.TabIndex = 5;
            this.lblIndex.Text = "<Index>";
            // 
            // lblAltitudeStart
            // 
            this.lblAltitudeStart.AutoSize = true;
            this.lblAltitudeStart.Location = new System.Drawing.Point(495, 20);
            this.lblAltitudeStart.Name = "lblAltitudeStart";
            this.lblAltitudeStart.Size = new System.Drawing.Size(86, 15);
            this.lblAltitudeStart.TabIndex = 9;
            this.lblAltitudeStart.Text = "<AltitudeStart>";
            // 
            // lblMaxCount
            // 
            this.lblMaxCount.AutoSize = true;
            this.lblMaxCount.Location = new System.Drawing.Point(3, 60);
            this.lblMaxCount.Name = "lblMaxCount";
            this.lblMaxCount.Size = new System.Drawing.Size(77, 15);
            this.lblMaxCount.TabIndex = 6;
            this.lblMaxCount.Text = "<MaxCount>";
            // 
            // lblMinCount
            // 
            this.lblMinCount.AutoSize = true;
            this.lblMinCount.Location = new System.Drawing.Point(249, 60);
            this.lblMinCount.Name = "lblMinCount";
            this.lblMinCount.Size = new System.Drawing.Size(74, 15);
            this.lblMinCount.TabIndex = 7;
            this.lblMinCount.Text = "<MinCount>";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(495, 60);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(80, 15);
            this.lblTotalCount.TabIndex = 8;
            this.lblTotalCount.Text = "<TotalCount>";
            // 
            // lblGpsTimeStart
            // 
            this.lblGpsTimeStart.AutoSize = true;
            this.lblGpsTimeStart.Location = new System.Drawing.Point(741, 20);
            this.lblGpsTimeStart.Name = "lblGpsTimeStart";
            this.lblGpsTimeStart.Size = new System.Drawing.Size(96, 15);
            this.lblGpsTimeStart.TabIndex = 10;
            this.lblGpsTimeStart.Text = "<GpsTimeStart>";
            // 
            // lblLatitudeEnd
            // 
            this.lblLatitudeEnd.AutoSize = true;
            this.lblLatitudeEnd.Location = new System.Drawing.Point(3, 40);
            this.lblLatitudeEnd.Name = "lblLatitudeEnd";
            this.lblLatitudeEnd.Size = new System.Drawing.Size(87, 15);
            this.lblLatitudeEnd.TabIndex = 11;
            this.lblLatitudeEnd.Text = "<LatitudeEnd>";
            // 
            // lblLongitudeEnd
            // 
            this.lblLongitudeEnd.AutoSize = true;
            this.lblLongitudeEnd.Location = new System.Drawing.Point(249, 40);
            this.lblLongitudeEnd.Name = "lblLongitudeEnd";
            this.lblLongitudeEnd.Size = new System.Drawing.Size(98, 15);
            this.lblLongitudeEnd.TabIndex = 12;
            this.lblLongitudeEnd.Text = "<LongitudeEnd>";
            // 
            // lblAltitudeEnd
            // 
            this.lblAltitudeEnd.AutoSize = true;
            this.lblAltitudeEnd.Location = new System.Drawing.Point(495, 40);
            this.lblAltitudeEnd.Name = "lblAltitudeEnd";
            this.lblAltitudeEnd.Size = new System.Drawing.Size(83, 15);
            this.lblAltitudeEnd.TabIndex = 13;
            this.lblAltitudeEnd.Text = "<AltitudeEnd>";
            // 
            // lblGpsTimeEnd
            // 
            this.lblGpsTimeEnd.AutoSize = true;
            this.lblGpsTimeEnd.Location = new System.Drawing.Point(741, 40);
            this.lblGpsTimeEnd.Name = "lblGpsTimeEnd";
            this.lblGpsTimeEnd.Size = new System.Drawing.Size(93, 15);
            this.lblGpsTimeEnd.TabIndex = 14;
            this.lblGpsTimeEnd.Text = "<GpsTimeEnd>";
            // 
            // lblDoserate
            // 
            this.lblDoserate.AutoSize = true;
            this.lblDoserate.Location = new System.Drawing.Point(741, 60);
            this.lblDoserate.Name = "lblDoserate";
            this.lblDoserate.Size = new System.Drawing.Size(71, 15);
            this.lblDoserate.TabIndex = 15;
            this.lblDoserate.Text = "<Doserate>";
            // 
            // tblSession
            // 
            this.tblSession.ColumnCount = 8;
            this.tblSession.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tblSession.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblSession.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblSession.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblSession.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblSession.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblSession.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblSession.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblSession.Controls.Add(this.label1, 0, 0);
            this.tblSession.Controls.Add(this.tbSpecCount, 1, 0);
            this.tblSession.Controls.Add(this.tbSpecLivetime, 2, 0);
            this.tblSession.Controls.Add(this.tbSpecDelay, 3, 0);
            this.tblSession.Controls.Add(this.btnSendSession, 4, 0);
            this.tblSession.Controls.Add(this.btnStopSession, 5, 0);
            this.tblSession.Controls.Add(this.btnSendClose, 7, 1);
            this.tblSession.Controls.Add(this.cbStoreChn, 6, 0);
            this.tblSession.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblSession.Location = new System.Drawing.Point(3, 3);
            this.tblSession.Name = "tblSession";
            this.tblSession.RowCount = 3;
            this.tblSession.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblSession.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblSession.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSession.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblSession.Size = new System.Drawing.Size(1194, 73);
            this.tblSession.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spectrum count, livetime and delay";
            // 
            // tbSpecCount
            // 
            this.tbSpecCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSpecCount.Location = new System.Drawing.Point(268, 3);
            this.tbSpecCount.Name = "tbSpecCount";
            this.tbSpecCount.Size = new System.Drawing.Size(126, 21);
            this.tbSpecCount.TabIndex = 18;
            // 
            // tbSpecLivetime
            // 
            this.tbSpecLivetime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSpecLivetime.Location = new System.Drawing.Point(400, 3);
            this.tbSpecLivetime.Name = "tbSpecLivetime";
            this.tbSpecLivetime.Size = new System.Drawing.Size(126, 21);
            this.tbSpecLivetime.TabIndex = 19;
            // 
            // tbSpecDelay
            // 
            this.tbSpecDelay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSpecDelay.Location = new System.Drawing.Point(532, 3);
            this.tbSpecDelay.Name = "tbSpecDelay";
            this.tbSpecDelay.Size = new System.Drawing.Size(126, 21);
            this.tbSpecDelay.TabIndex = 20;
            // 
            // btnSendSession
            // 
            this.btnSendSession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSendSession.Location = new System.Drawing.Point(664, 3);
            this.btnSendSession.Name = "btnSendSession";
            this.btnSendSession.Size = new System.Drawing.Size(126, 24);
            this.btnSendSession.TabIndex = 17;
            this.btnSendSession.Text = "Start new session";
            this.btnSendSession.UseVisualStyleBackColor = true;
            this.btnSendSession.Click += new System.EventHandler(this.btnSendSession_Click);
            // 
            // btnStopSession
            // 
            this.btnStopSession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStopSession.Location = new System.Drawing.Point(796, 3);
            this.btnStopSession.Name = "btnStopSession";
            this.btnStopSession.Size = new System.Drawing.Size(126, 24);
            this.btnStopSession.TabIndex = 21;
            this.btnStopSession.Text = "Stop session";
            this.btnStopSession.UseVisualStyleBackColor = true;
            this.btnStopSession.Click += new System.EventHandler(this.btnStopSession_Click);
            // 
            // btnSendClose
            // 
            this.btnSendClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSendClose.Location = new System.Drawing.Point(1060, 33);
            this.btnSendClose.Name = "btnSendClose";
            this.btnSendClose.Size = new System.Drawing.Size(131, 24);
            this.btnSendClose.TabIndex = 2;
            this.btnSendClose.Text = "Send close";
            this.btnSendClose.UseVisualStyleBackColor = true;
            this.btnSendClose.Click += new System.EventHandler(this.btnSendClose_Click);
            // 
            // cbStoreChn
            // 
            this.cbStoreChn.AutoSize = true;
            this.cbStoreChn.Location = new System.Drawing.Point(928, 3);
            this.cbStoreChn.Name = "cbStoreChn";
            this.cbStoreChn.Size = new System.Drawing.Size(109, 19);
            this.cbStoreChn.TabIndex = 16;
            this.cbStoreChn.Text = "Store CHN files";
            this.cbStoreChn.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 749);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.tools);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crash";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.pageSetup.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pageMenu.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pageSession.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tblSession.ResumeLayout(false);
            this.tblSession.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripButton btnConnect;
        private System.Windows.Forms.ToolStripMenuItem menuItemConnect;
        private System.Windows.Forms.ToolStripMenuItem menuItemDisconnect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnDisconnect;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripLabel lblConnectionStatus;
        private TabControlWizard.TabControlWizard tabs;
        private System.Windows.Forms.TabPage pageSetup;
        private System.Windows.Forms.TabPage pageMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnMenuSetup;
        private System.Windows.Forms.ToolStripButton btnBack;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TabPage pageSession;
        private System.Windows.Forms.Button btnMenuSession;
        private System.Windows.Forms.TableLayoutPanel tblSession;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSpecCount;
        private System.Windows.Forms.TextBox tbSpecLivetime;
        private System.Windows.Forms.TextBox tbSpecDelay;
        private System.Windows.Forms.Button btnSendSession;
        private System.Windows.Forms.Button btnStopSession;
        private System.Windows.Forms.CheckBox cbStoreChn;
        private System.Windows.Forms.Button btnSendClose;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbSetupVoltage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSetupCoarseGain;
        private System.Windows.Forms.TextBox tbSetupFineGain;
        private System.Windows.Forms.Button btnSetupSetParams;
        private System.Windows.Forms.ComboBox cboxSetupDetector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxSetupChannels;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSetupLLD;
        private System.Windows.Forms.TextBox tbSetupULD;
        private System.Windows.Forms.TextBox tbSetupLivetime;
        private System.Windows.Forms.Button btnSetupStop;
        private System.Windows.Forms.Button btnSetupStart;
        private System.Windows.Forms.Button btnSetupStoreParams;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem menuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem menuItemPreferences;
        private System.Windows.Forms.ToolStripButton btnPreferences;
        private System.Windows.Forms.ToolStripButton btnShowWaterfallLive;
        private System.Windows.Forms.ToolStripLabel lblInterface;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnShowWaterfallHist;
        private System.Windows.Forms.ToolStripButton btnShowROIChart;
        private System.Windows.Forms.ListBox lbSession;
        private ZedGraph.ZedGraphControl graphSetup;
        private System.Windows.Forms.ToolStripButton btnShowMap;
        private System.Windows.Forms.ToolStripButton btnShowLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ZedGraph.ZedGraphControl graphSession;
        private System.Windows.Forms.Label lblLatitudeStart;
        private System.Windows.Forms.Label lblLongitudeStart;
        private System.Windows.Forms.Label lblRealtime;
        private System.Windows.Forms.Label lblLivetime;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Label lblMaxCount;
        private System.Windows.Forms.Label lblMinCount;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblAltitudeStart;
        private System.Windows.Forms.Label lblGpsTimeStart;
        private System.Windows.Forms.Label lblLatitudeEnd;
        private System.Windows.Forms.Label lblLongitudeEnd;
        private System.Windows.Forms.Label lblAltitudeEnd;
        private System.Windows.Forms.Label lblGpsTimeEnd;
        private System.Windows.Forms.ToolStripButton btnShow3D;
        private System.Windows.Forms.Label lblDoserate;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
        private System.Windows.Forms.ToolStripButton btnShowDoserate;
        private System.Windows.Forms.Label lblSetupDoserate;
        private System.Windows.Forms.ToolStripMenuItem menuItemSession;
        private System.Windows.Forms.ToolStripMenuItem menuItemLoadSession;
        private System.Windows.Forms.ToolStripMenuItem menuItemSaveCHN;
        private System.Windows.Forms.ToolStripMenuItem menuItemSaveIrix;
        private System.Windows.Forms.ToolStripMenuItem menuItemLoadBackgroundSession;
    }
}

