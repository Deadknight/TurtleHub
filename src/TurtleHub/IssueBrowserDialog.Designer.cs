// This file is part of TurtleHub.
// 
// Copyright (C)2013 Justin Dailey <dail8859@yahoo.com>
// 
// TurtleHub is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either
// version 2 of the License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 675 Mass Ave, Cambridge, MA 02139, USA.

namespace TurtleHub
{
    partial class IssueBrowserDialog
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
            System.Windows.Forms.StatusStrip statusStrip;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.workStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnReload = new System.Windows.Forms.Button();
            this.updateNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.BtnShowGithub = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.checkBoxShowPrs = new System.Windows.Forms.CheckBox();
            this.CbOpened = new System.Windows.Forms.ComboBox();
            this.CbAssigned = new System.Windows.Forms.ComboBox();
            this.TxtLabels = new System.Windows.Forms.TextBox();
            this.CbMilestone = new System.Windows.Forms.ComboBox();
            statusStrip = new System.Windows.Forms.StatusStrip();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.workStatus});
            statusStrip.Location = new System.Drawing.Point(0, 462);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            statusStrip.Size = new System.Drawing.Size(1273, 25);
            statusStrip.TabIndex = 12;
            // 
            // statusLabel
            // 
            this.statusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(1259, 20);
            this.statusLabel.Spring = true;
            this.statusLabel.Text = "Ready";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // workStatus
            // 
            this.workStatus.AutoSize = false;
            this.workStatus.MarqueeAnimationSpeed = 10;
            this.workStatus.Name = "workStatus";
            this.workStatus.Size = new System.Drawing.Size(725, 19);
            this.workStatus.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.workStatus.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(55, 17);
            label1.TabIndex = 14;
            label1.Text = "Search:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(245, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(61, 17);
            label2.TabIndex = 17;
            label2.Text = "Opened:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(439, 9);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(66, 17);
            label3.TabIndex = 19;
            label3.Text = "Assigned:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(638, 8);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(50, 17);
            label4.TabIndex = 21;
            label4.Text = "Labels:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(871, 8);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(68, 17);
            label5.TabIndex = 23;
            label5.Text = "Milestone:";
            // 
            // BtnOk
            // 
            this.BtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnOk.Location = new System.Drawing.Point(1105, 432);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 3;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnCancel.Location = new System.Drawing.Point(1186, 432);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnReload
            // 
            this.BtnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnReload.Location = new System.Drawing.Point(12, 432);
            this.BtnReload.Name = "BtnReload";
            this.BtnReload.Size = new System.Drawing.Size(77, 23);
            this.BtnReload.TabIndex = 3;
            this.BtnReload.Text = "Reload";
            this.BtnReload.UseVisualStyleBackColor = true;
            this.BtnReload.Visible = false;
            this.BtnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // updateNotifyIcon
            // 
            this.updateNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.updateNotifyIcon.BalloonTipText = "TurtleHub {0} is available for download!\r\n";
            this.updateNotifyIcon.BalloonTipTitle = "TurtleHub Update";
            this.updateNotifyIcon.Text = "TurtleHub Update Available";
            this.updateNotifyIcon.BalloonTipClicked += new System.EventHandler(this.updateNotifyIcon_Click);
            // 
            // BtnShowGithub
            // 
            this.BtnShowGithub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnShowGithub.Enabled = false;
            this.BtnShowGithub.Location = new System.Drawing.Point(12, 432);
            this.BtnShowGithub.Name = "BtnShowGithub";
            this.BtnShowGithub.Size = new System.Drawing.Size(96, 22);
            this.BtnShowGithub.TabIndex = 2;
            this.BtnShowGithub.Text = "Show on Github";
            this.BtnShowGithub.UseVisualStyleBackColor = true;
            this.BtnShowGithub.Click += new System.EventHandler(this.BtnShowGithub_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(73, 6);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(166, 24);
            this.TxtSearch.TabIndex = 0;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.olvColumn1);
            this.objectListView1.AllColumns.Add(this.olvColumn2);
            this.objectListView1.AllColumns.Add(this.olvColumn3);
            this.objectListView1.AllColumns.Add(this.olvColumn4);
            this.objectListView1.AllColumns.Add(this.olvColumn5);
            this.objectListView1.AllColumns.Add(this.olvColumn6);
            this.objectListView1.AlternateRowBackColor = System.Drawing.Color.WhiteSmoke;
            this.objectListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.CheckBoxes = true;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5,
            this.olvColumn6});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.GridLines = true;
            this.objectListView1.HasCollapsibleGroups = false;
            this.objectListView1.HideSelection = false;
            this.objectListView1.Location = new System.Drawing.Point(0, 33);
            this.objectListView1.MultiSelect = false;
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.OverlayText.Text = "";
            this.objectListView1.SelectAllOnControlA = false;
            this.objectListView1.ShowFilterMenuOnRightClick = false;
            this.objectListView1.ShowGroups = false;
            this.objectListView1.Size = new System.Drawing.Size(1273, 393);
            this.objectListView1.TabIndex = 1;
            this.objectListView1.UseAlternatingBackColors = true;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.UseHotControls = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            this.objectListView1.SelectionChanged += new System.EventHandler(this.objectListView1_SelectionChanged);
            // 
            // olvColumn1
            // 
            this.olvColumn1.Text = "#";
            this.olvColumn1.Width = 90;
            // 
            // olvColumn2
            // 
            this.olvColumn2.FillsFreeSpace = true;
            this.olvColumn2.Text = "Summary";
            this.olvColumn2.Width = 632;
            // 
            // olvColumn3
            // 
            this.olvColumn3.Text = "Opened By";
            this.olvColumn3.Width = 72;
            // 
            // olvColumn4
            // 
            this.olvColumn4.Text = "Assigned To";
            this.olvColumn4.Width = 72;
            // 
            // olvColumn5
            // 
            this.olvColumn5.Text = "Labels";
            this.olvColumn5.Width = 200;
            // 
            // olvColumn6
            // 
            this.olvColumn6.Text = "Milestone";
            this.olvColumn6.Width = 200;
            // 
            // checkBoxShowPrs
            // 
            this.checkBoxShowPrs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxShowPrs.AutoSize = true;
            this.checkBoxShowPrs.Location = new System.Drawing.Point(138, 432);
            this.checkBoxShowPrs.Name = "checkBoxShowPrs";
            this.checkBoxShowPrs.Size = new System.Drawing.Size(148, 21);
            this.checkBoxShowPrs.TabIndex = 15;
            this.checkBoxShowPrs.Text = "Show Pull Requests";
            this.checkBoxShowPrs.UseVisualStyleBackColor = true;
            this.checkBoxShowPrs.CheckedChanged += new System.EventHandler(this.checkBoxShowPrs_CheckedChanged);
            // 
            // CbOpened
            // 
            this.CbOpened.FormattingEnabled = true;
            this.CbOpened.Location = new System.Drawing.Point(312, 5);
            this.CbOpened.Name = "CbOpened";
            this.CbOpened.Size = new System.Drawing.Size(121, 25);
            this.CbOpened.TabIndex = 16;
            this.CbOpened.TextChanged += new System.EventHandler(this.CbOpened_TextChanged);
            // 
            // CbAssigned
            // 
            this.CbAssigned.FormattingEnabled = true;
            this.CbAssigned.Location = new System.Drawing.Point(511, 5);
            this.CbAssigned.Name = "CbAssigned";
            this.CbAssigned.Size = new System.Drawing.Size(121, 25);
            this.CbAssigned.TabIndex = 18;
            this.CbAssigned.TextChanged += new System.EventHandler(this.CbAssigned_TextChanged);
            // 
            // TxtLabels
            // 
            this.TxtLabels.Location = new System.Drawing.Point(699, 5);
            this.TxtLabels.Name = "TxtLabels";
            this.TxtLabels.Size = new System.Drawing.Size(166, 24);
            this.TxtLabels.TabIndex = 20;
            this.TxtLabels.TextChanged += new System.EventHandler(this.TxtLabels_TextChanged);
            // 
            // CbMilestone
            // 
            this.CbMilestone.FormattingEnabled = true;
            this.CbMilestone.Location = new System.Drawing.Point(945, 5);
            this.CbMilestone.Name = "CbMilestone";
            this.CbMilestone.Size = new System.Drawing.Size(121, 25);
            this.CbMilestone.TabIndex = 22;
            this.CbMilestone.TextChanged += new System.EventHandler(this.CbMilestone_TextChanged);
            // 
            // IssueBrowserDialog
            // 
            this.AcceptButton = this.BtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(1273, 487);
            this.Controls.Add(label5);
            this.Controls.Add(this.CbMilestone);
            this.Controls.Add(this.TxtLabels);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.CbAssigned);
            this.Controls.Add(label2);
            this.Controls.Add(this.CbOpened);
            this.Controls.Add(this.checkBoxShowPrs);
            this.Controls.Add(this.objectListView1);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(label1);
            this.Controls.Add(this.BtnShowGithub);
            this.Controls.Add(statusStrip);
            this.Controls.Add(this.BtnReload);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.MinimizeBox = false;
            this.Name = "IssueBrowserDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Issues for {0}";
            this.Load += new System.EventHandler(this.IssueBrowserDialog_Load);
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnReload;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.NotifyIcon updateNotifyIcon;
        private System.Windows.Forms.Button BtnShowGithub;
        private System.Windows.Forms.TextBox TxtSearch;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private System.Windows.Forms.ToolStripProgressBar workStatus;
        private System.Windows.Forms.CheckBox checkBoxShowPrs;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private System.Windows.Forms.ComboBox CbOpened;
        private System.Windows.Forms.ComboBox CbAssigned;
        private System.Windows.Forms.TextBox TxtLabels;
        private System.Windows.Forms.ComboBox CbMilestone;
    }
}