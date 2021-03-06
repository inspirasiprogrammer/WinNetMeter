﻿namespace WinNetMeter.UserControls.Pages
{
    partial class Log
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkDefaultLoc = new System.Windows.Forms.LinkLabel();
            this.txtLogPath = new System.Windows.Forms.TextBox();
            this.btnBrowseLog = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.toggleTraffic = new MetroFramework.Controls.MetroToggle();
            this.btnSaveLog = new System.Windows.Forms.Button();
            this.BtnTestHit = new WinNetMeter.Components.ButtonEx();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkDefaultLoc);
            this.groupBox1.Controls.Add(this.txtLogPath);
            this.groupBox1.Controls.Add(this.btnBrowseLog);
            this.groupBox1.Location = new System.Drawing.Point(26, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 110);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log location";
            // 
            // linkDefaultLoc
            // 
            this.linkDefaultLoc.AutoSize = true;
            this.linkDefaultLoc.Location = new System.Drawing.Point(10, 81);
            this.linkDefaultLoc.Name = "linkDefaultLoc";
            this.linkDefaultLoc.Size = new System.Drawing.Size(110, 13);
            this.linkDefaultLoc.TabIndex = 10;
            this.linkDefaultLoc.TabStop = true;
            this.linkDefaultLoc.Text = "Set to default location";
            // 
            // txtLogPath
            // 
            this.txtLogPath.Location = new System.Drawing.Point(13, 43);
            this.txtLogPath.Name = "txtLogPath";
            this.txtLogPath.Size = new System.Drawing.Size(391, 20);
            this.txtLogPath.TabIndex = 8;
            // 
            // btnBrowseLog
            // 
            this.btnBrowseLog.Location = new System.Drawing.Point(410, 41);
            this.btnBrowseLog.Name = "btnBrowseLog";
            this.btnBrowseLog.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseLog.TabIndex = 9;
            this.btnBrowseLog.Text = "...";
            this.btnBrowseLog.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Traffic log";
            // 
            // toggleTraffic
            // 
            this.toggleTraffic.AutoSize = true;
            this.toggleTraffic.Checked = true;
            this.toggleTraffic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleTraffic.Enabled = false;
            this.toggleTraffic.Location = new System.Drawing.Point(441, 10);
            this.toggleTraffic.Name = "toggleTraffic";
            this.toggleTraffic.Size = new System.Drawing.Size(80, 17);
            this.toggleTraffic.TabIndex = 15;
            this.toggleTraffic.Text = "On";
            this.toggleTraffic.UseSelectable = true;
            this.toggleTraffic.CheckedChanged += new System.EventHandler(this.ToggleTraffic_CheckedChanged);
            // 
            // btnSaveLog
            // 
            this.btnSaveLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveLog.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveLog.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSaveLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveLog.ForeColor = System.Drawing.Color.Black;
            this.btnSaveLog.Image = global::WinNetMeter.Properties.Resources.Checked_outline_16px;
            this.btnSaveLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveLog.Location = new System.Drawing.Point(414, 375);
            this.btnSaveLog.Name = "btnSaveLog";
            this.btnSaveLog.Size = new System.Drawing.Size(121, 33);
            this.btnSaveLog.TabIndex = 18;
            this.btnSaveLog.Text = "  Save";
            this.btnSaveLog.UseVisualStyleBackColor = false;
            this.btnSaveLog.Click += new System.EventHandler(this.BtnSaveLog_Click);
            // 
            // BtnTestHit
            // 
            this.BtnTestHit.Location = new System.Drawing.Point(404, 216);
            this.BtnTestHit.Name = "BtnTestHit";
            this.BtnTestHit.Size = new System.Drawing.Size(107, 43);
            this.BtnTestHit.TabIndex = 19;
            this.BtnTestHit.Text = "buttonEx1";
            this.BtnTestHit.UseVisualStyleBackColor = true;
            this.BtnTestHit.Click += new System.EventHandler(this.BtnTestHit_Click);
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.BtnTestHit);
            this.Controls.Add(this.btnSaveLog);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.toggleTraffic);
            this.Name = "Log";
            this.Size = new System.Drawing.Size(560, 420);
            this.Load += new System.EventHandler(this.Log_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSaveLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkDefaultLoc;
        private System.Windows.Forms.TextBox txtLogPath;
        private System.Windows.Forms.Button btnBrowseLog;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroToggle toggleTraffic;
        private Components.ButtonEx BtnTestHit;
    }
}
