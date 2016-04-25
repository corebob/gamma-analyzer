﻿namespace crash
{
    partial class FormWaterfallLive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWaterfallLive));
            this.tools = new System.Windows.Forms.ToolStrip();
            this.pane = new System.Windows.Forms.Panel();
            this.tbColorCeil = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpAll = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnDownAll = new System.Windows.Forms.Button();
            this.btnRightAll = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnLeftAll = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblColorCeil = new System.Windows.Forms.Label();
            this.lblChannel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbColorCeil)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tools
            // 
            this.tools.Location = new System.Drawing.Point(0, 0);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(939, 25);
            this.tools.TabIndex = 0;
            this.tools.Text = "toolStrip1";
            // 
            // pane
            // 
            this.pane.BackColor = System.Drawing.Color.Blue;
            this.pane.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pane.Location = new System.Drawing.Point(0, 25);
            this.pane.Name = "pane";
            this.pane.Size = new System.Drawing.Size(909, 485);
            this.pane.TabIndex = 2;
            this.pane.Paint += new System.Windows.Forms.PaintEventHandler(this.pane_Paint);
            this.pane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pane_MouseDown);
            this.pane.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pane_MouseMove);
            this.pane.Resize += new System.EventHandler(this.pane_Resize);
            // 
            // tbColorCeil
            // 
            this.tbColorCeil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbColorCeil.Location = new System.Drawing.Point(0, 0);
            this.tbColorCeil.Name = "tbColorCeil";
            this.tbColorCeil.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbColorCeil.Size = new System.Drawing.Size(30, 345);
            this.tbColorCeil.TabIndex = 3;
            this.tbColorCeil.Scroll += new System.EventHandler(this.tbColorCeil_Scroll);
            this.tbColorCeil.ValueChanged += new System.EventHandler(this.tbColorCeil_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblChannel);
            this.panel1.Controls.Add(this.lblColorCeil);
            this.panel1.Controls.Add(this.btnLeftAll);
            this.panel1.Controls.Add(this.btnLeft);
            this.panel1.Controls.Add(this.btnRight);
            this.panel1.Controls.Add(this.btnRightAll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 510);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 26);
            this.panel1.TabIndex = 4;
            // 
            // btnUpAll
            // 
            this.btnUpAll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUpAll.FlatAppearance.BorderSize = 0;
            this.btnUpAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpAll.Image = global::crash.Properties.Resources.up_all_16;
            this.btnUpAll.Location = new System.Drawing.Point(0, 345);
            this.btnUpAll.Name = "btnUpAll";
            this.btnUpAll.Size = new System.Drawing.Size(30, 35);
            this.btnUpAll.TabIndex = 7;
            this.btnUpAll.UseVisualStyleBackColor = true;
            this.btnUpAll.Click += new System.EventHandler(this.btnUpAll_Click);
            // 
            // btnUp
            // 
            this.btnUp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUp.FlatAppearance.BorderSize = 0;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Image = global::crash.Properties.Resources.up_16;
            this.btnUp.Location = new System.Drawing.Point(0, 380);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(30, 35);
            this.btnUp.TabIndex = 6;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDown.FlatAppearance.BorderSize = 0;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Image = global::crash.Properties.Resources.down_16;
            this.btnDown.Location = new System.Drawing.Point(0, 415);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(30, 35);
            this.btnDown.TabIndex = 5;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnDownAll
            // 
            this.btnDownAll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDownAll.FlatAppearance.BorderSize = 0;
            this.btnDownAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownAll.Image = global::crash.Properties.Resources.down_all_16;
            this.btnDownAll.Location = new System.Drawing.Point(0, 450);
            this.btnDownAll.Name = "btnDownAll";
            this.btnDownAll.Size = new System.Drawing.Size(30, 35);
            this.btnDownAll.TabIndex = 4;
            this.btnDownAll.UseVisualStyleBackColor = true;
            this.btnDownAll.Click += new System.EventHandler(this.btnDownAll_Click);
            // 
            // btnRightAll
            // 
            this.btnRightAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRightAll.FlatAppearance.BorderSize = 0;
            this.btnRightAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRightAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRightAll.Image = global::crash.Properties.Resources.right_all_16;
            this.btnRightAll.Location = new System.Drawing.Point(869, 0);
            this.btnRightAll.Name = "btnRightAll";
            this.btnRightAll.Size = new System.Drawing.Size(40, 26);
            this.btnRightAll.TabIndex = 3;
            this.btnRightAll.UseVisualStyleBackColor = true;
            this.btnRightAll.Click += new System.EventHandler(this.btnRightAll_Click);
            // 
            // btnRight
            // 
            this.btnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Image = global::crash.Properties.Resources.right_16;
            this.btnRight.Location = new System.Drawing.Point(829, 0);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(40, 26);
            this.btnRight.TabIndex = 2;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Image = global::crash.Properties.Resources.left_16;
            this.btnLeft.Location = new System.Drawing.Point(789, 0);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(40, 26);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnLeftAll
            // 
            this.btnLeftAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLeftAll.FlatAppearance.BorderSize = 0;
            this.btnLeftAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeftAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeftAll.Image = global::crash.Properties.Resources.left_all_16;
            this.btnLeftAll.Location = new System.Drawing.Point(749, 0);
            this.btnLeftAll.Name = "btnLeftAll";
            this.btnLeftAll.Size = new System.Drawing.Size(40, 26);
            this.btnLeftAll.TabIndex = 0;
            this.btnLeftAll.UseVisualStyleBackColor = true;
            this.btnLeftAll.Click += new System.EventHandler(this.btnLeftAll_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbColorCeil);
            this.panel2.Controls.Add(this.btnUpAll);
            this.panel2.Controls.Add(this.btnUp);
            this.panel2.Controls.Add(this.btnDown);
            this.panel2.Controls.Add(this.btnDownAll);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(909, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 511);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 485);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 26);
            this.panel3.TabIndex = 5;
            // 
            // lblColorCeil
            // 
            this.lblColorCeil.AutoSize = true;
            this.lblColorCeil.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblColorCeil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorCeil.Location = new System.Drawing.Point(0, 0);
            this.lblColorCeil.Name = "lblColorCeil";
            this.lblColorCeil.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lblColorCeil.Size = new System.Drawing.Size(84, 17);
            this.lblColorCeil.TabIndex = 4;
            this.lblColorCeil.Text = "<lblColorCeil>";
            // 
            // lblChannel
            // 
            this.lblChannel.AutoSize = true;
            this.lblChannel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChannel.Location = new System.Drawing.Point(84, 0);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Padding = new System.Windows.Forms.Padding(5, 2, 0, 0);
            this.lblChannel.Size = new System.Drawing.Size(85, 17);
            this.lblChannel.TabIndex = 5;
            this.lblChannel.Text = "<lblChannel>";
            // 
            // FormWaterfallLive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 536);
            this.Controls.Add(this.pane);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tools);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 320);
            this.Name = "FormWaterfallLive";
            this.Text = "Crash - Waterfall Live";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormWaterfall_FormClosing);
            this.Load += new System.EventHandler(this.FormWaterfall_Load);
            this.ResizeBegin += new System.EventHandler(this.FormWaterfallLive_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.FormWaterfallLive_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.tbColorCeil)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.Panel pane;
        private System.Windows.Forms.TrackBar tbColorCeil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRightAll;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnLeftAll;
        private System.Windows.Forms.Button btnUpAll;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnDownAll;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.Label lblColorCeil;
    }
}