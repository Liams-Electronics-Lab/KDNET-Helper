using System;
using System.Drawing;
using System.Windows.Forms;

namespace KdnetHelper
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TabControl tabControl;
        private TabPage tabTarget;
        private TabPage tabHost;
        private TabPage tabAbout;   // <-- added

        // Target tab controls
        private RichTextBox txtTargetLog;
        private TextBox txtHostIp;
        private TextBox txtPort;
        private TextBox txtGeneratedKey;
        private Button btnCheckNIC;
        private Button btnEnableKDNET;
        private Button btnDisableDebug;
        private Button btnCreateRestorePoint;
        private Button btnVerifyDebugSettings;
        private Button btnDisableBitLocker;
        private Button btnEnableBitLocker;
        private Button btnDisableSecureBoot;
        private Button btnEnableSecureBoot;
        private CheckBox chkShareKey;
        private ComboBox cmbTargetIPs;
        private Label lblTargetHostIp;
        private Label lblTargetPort;
        private Label lblTargetGeneratedKey;
        private Label lblTargetIPs;

        // Host tab controls
        private RichTextBox txtHostLog;
        private ComboBox cmbHostIPs;
        private TextBox txtHostPort;
        private TextBox txtHostKey;
        private TextBox txtTargetIP;
        private Button btnLaunchWinDbg;
        private Button btnRefreshIPs;
        private Button btnExportLog;
        private Button btnFetchKey;
        private Button btnCopyKeyHost;
        private DataGridView dgvDiscovered;
        private Label lblHostRef;
        private Label lblHostPort;
        private Label lblHostKey;
        private Label lblTargetIPLabel;
        private Panel separatorLine;

        // Auto-scroll checkboxes
        private CheckBox chkTargetAutoScroll;
        private CheckBox chkHostAutoScroll;

        // About tab controls
        private RichTextBox txtAbout;
        private LinkLabel linkYouTube;
        private LinkLabel linkGitHub;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new TabControl();
            this.tabTarget = new TabPage();
            this.tabHost = new TabPage();
            this.tabAbout = new TabPage();    // <-- create the tab page

            // Target controls
            this.txtTargetLog = new RichTextBox();
            this.txtHostIp = new TextBox();
            this.txtPort = new TextBox();
            this.txtGeneratedKey = new TextBox();
            this.btnCheckNIC = new Button();
            this.btnEnableKDNET = new Button();
            this.btnDisableDebug = new Button();
            this.btnCreateRestorePoint = new Button();
            this.btnVerifyDebugSettings = new Button();
            this.btnDisableBitLocker = new Button();
            this.btnEnableBitLocker = new Button();
            this.btnDisableSecureBoot = new Button();
            this.btnEnableSecureBoot = new Button();
            this.chkShareKey = new CheckBox();
            this.cmbTargetIPs = new ComboBox();
            this.lblTargetHostIp = new Label();
            this.lblTargetPort = new Label();
            this.lblTargetGeneratedKey = new Label();
            this.lblTargetIPs = new Label();
            this.chkTargetAutoScroll = new CheckBox();

            // Host controls
            this.txtHostLog = new RichTextBox();
            this.cmbHostIPs = new ComboBox();
            this.txtHostPort = new TextBox();
            this.txtHostKey = new TextBox();
            this.txtTargetIP = new TextBox();
            this.btnLaunchWinDbg = new Button();
            this.btnRefreshIPs = new Button();
            this.btnExportLog = new Button();
            this.btnFetchKey = new Button();
            this.btnCopyKeyHost = new Button();
            this.dgvDiscovered = new DataGridView();
            this.lblHostRef = new Label();
            this.lblHostPort = new Label();
            this.lblHostKey = new Label();
            this.lblTargetIPLabel = new Label();
            this.separatorLine = new Panel();
            this.chkHostAutoScroll = new CheckBox();

            // About controls
            this.txtAbout = new RichTextBox();
            this.linkYouTube = new LinkLabel();
            this.linkGitHub = new LinkLabel();

            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscovered)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabTarget.SuspendLayout();
            this.tabHost.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.SuspendLayout();

            // ==================================================
            // tabControl
            // ==================================================
            this.tabControl.Controls.Add(this.tabTarget);
            this.tabControl.Controls.Add(this.tabHost);
            this.tabControl.Controls.Add(this.tabAbout);   // <-- add About tab
            this.tabControl.Dock = DockStyle.Fill;
            this.tabControl.Location = new Point(0, 0);
            this.tabControl.Size = new Size(950, 750);
            this.tabControl.TabIndex = 0;

            // ========== TARGET TAB (same as yours, with corrected log height) ==========
            this.tabTarget.Controls.Add(this.btnCheckNIC);
            this.tabTarget.Controls.Add(this.btnEnableKDNET);
            this.tabTarget.Controls.Add(this.btnDisableDebug);
            this.tabTarget.Controls.Add(this.btnCreateRestorePoint);
            this.tabTarget.Controls.Add(this.btnVerifyDebugSettings);
            this.tabTarget.Controls.Add(this.btnDisableBitLocker);
            this.tabTarget.Controls.Add(this.btnEnableBitLocker);
            this.tabTarget.Controls.Add(this.btnDisableSecureBoot);
            this.tabTarget.Controls.Add(this.btnEnableSecureBoot);
            this.tabTarget.Controls.Add(this.chkShareKey);
            this.tabTarget.Controls.Add(this.cmbTargetIPs);
            this.tabTarget.Controls.Add(this.txtHostIp);
            this.tabTarget.Controls.Add(this.txtPort);
            this.tabTarget.Controls.Add(this.txtGeneratedKey);
            this.tabTarget.Controls.Add(this.txtTargetLog);
            this.tabTarget.Controls.Add(this.lblTargetHostIp);
            this.tabTarget.Controls.Add(this.lblTargetPort);
            this.tabTarget.Controls.Add(this.lblTargetGeneratedKey);
            this.tabTarget.Controls.Add(this.lblTargetIPs);
            this.tabTarget.Controls.Add(this.chkTargetAutoScroll);
            this.tabTarget.Text = "Target Machine Setup";
            this.tabTarget.UseVisualStyleBackColor = true;

            // Target labels
            this.lblTargetHostIp.Text = "Host IP Address:";
            this.lblTargetHostIp.Location = new Point(12, 15);
            this.lblTargetHostIp.Size = new Size(100, 23);
            this.lblTargetHostIp.TextAlign = ContentAlignment.MiddleRight;

            this.lblTargetPort.Text = "Port (50000-50039):";
            this.lblTargetPort.Location = new Point(12, 45);
            this.lblTargetPort.Size = new Size(100, 23);
            this.lblTargetPort.TextAlign = ContentAlignment.MiddleRight;

            this.lblTargetGeneratedKey.Text = "Current Debug Key:";
            this.lblTargetGeneratedKey.Location = new Point(12, 160);
            this.lblTargetGeneratedKey.Size = new Size(110, 23);
            this.lblTargetGeneratedKey.TextAlign = ContentAlignment.MiddleRight;

            this.lblTargetIPs.Text = "This Machine IP(s):";
            this.lblTargetIPs.Location = new Point(12, 195);
            this.lblTargetIPs.Size = new Size(110, 23);
            this.lblTargetIPs.TextAlign = ContentAlignment.MiddleRight;

            // Target textboxes
            this.txtHostIp.Location = new Point(120, 15);
            this.txtHostIp.Size = new Size(150, 23);
            this.txtHostIp.Text = "192.168.1.100";

            this.txtPort.Location = new Point(120, 45);
            this.txtPort.Size = new Size(80, 23);
            this.txtPort.Text = "50005";

            this.txtGeneratedKey.Location = new Point(130, 160);
            this.txtGeneratedKey.Size = new Size(300, 23);
            this.txtGeneratedKey.ReadOnly = true;

            this.cmbTargetIPs.Location = new Point(130, 195);
            this.cmbTargetIPs.Size = new Size(200, 23);
            this.cmbTargetIPs.DropDownStyle = ComboBoxStyle.DropDownList;

            this.chkShareKey.Text = "Share Key via Network (temp)";
            this.chkShareKey.Location = new Point(480, 160);
            this.chkShareKey.Size = new Size(180, 23);
            this.chkShareKey.CheckedChanged += new EventHandler(this.chkShareKey_CheckedChanged);

            // Target buttons
            this.btnCheckNIC.Text = "Check NIC";
            this.btnCheckNIC.Location = new Point(290, 12);
            this.btnCheckNIC.Size = new Size(120, 30);
            this.btnCheckNIC.Click += new EventHandler(this.btnCheckNIC_Click);

            this.btnEnableKDNET.Text = "Enable KDNET";
            this.btnEnableKDNET.Location = new Point(290, 45);
            this.btnEnableKDNET.Size = new Size(120, 30);
            this.btnEnableKDNET.Click += new EventHandler(this.btnEnableKDNET_Click);

            this.btnDisableDebug.Text = "Disable Debug";
            this.btnDisableDebug.Location = new Point(430, 12);
            this.btnDisableDebug.Size = new Size(130, 30);
            this.btnDisableDebug.Click += new EventHandler(this.btnDisableDebug_Click);

            this.btnCreateRestorePoint.Text = "Restore Point";
            this.btnCreateRestorePoint.Location = new Point(430, 45);
            this.btnCreateRestorePoint.Size = new Size(130, 30);
            this.btnCreateRestorePoint.Click += new EventHandler(this.btnCreateRestorePoint_Click);

            this.btnVerifyDebugSettings.Text = "Verify";
            this.btnVerifyDebugSettings.Location = new Point(580, 12);
            this.btnVerifyDebugSettings.Size = new Size(90, 63);
            this.btnVerifyDebugSettings.Click += new EventHandler(this.btnVerifyDebugSettings_Click);

            this.btnDisableBitLocker.Text = "Disable BitLocker";
            this.btnDisableBitLocker.Location = new Point(290, 82);
            this.btnDisableBitLocker.Size = new Size(130, 30);
            this.btnDisableBitLocker.Click += new EventHandler(this.btnDisableBitLocker_Click);

            this.btnEnableBitLocker.Text = "Re-enable BitLocker";
            this.btnEnableBitLocker.Location = new Point(430, 82);
            this.btnEnableBitLocker.Size = new Size(130, 30);
            this.btnEnableBitLocker.Click += new EventHandler(this.btnEnableBitLocker_Click);

            this.btnDisableSecureBoot.Text = "Disable Secure Boot";
            this.btnDisableSecureBoot.Location = new Point(290, 118);
            this.btnDisableSecureBoot.Size = new Size(130, 30);
            this.btnDisableSecureBoot.Click += new EventHandler(this.btnDisableSecureBoot_Click);

            this.btnEnableSecureBoot.Text = "Re-enable Secure Boot";
            this.btnEnableSecureBoot.Location = new Point(430, 118);
            this.btnEnableSecureBoot.Size = new Size(130, 30);
            this.btnEnableSecureBoot.Click += new EventHandler(this.btnEnableSecureBoot_Click);

            // Target log (RichTextBox) 
            this.txtTargetLog.Location = new Point(5, 235);
            this.txtTargetLog.Size = new Size(920, 420);   
            this.txtTargetLog.Multiline = true;
            this.txtTargetLog.ScrollBars = RichTextBoxScrollBars.Vertical;
            this.txtTargetLog.ReadOnly = true;
            this.txtTargetLog.WordWrap = true;
            this.txtTargetLog.BackColor = SystemColors.Window;

            // Target auto-scroll checkbox
            this.chkTargetAutoScroll.Text = "Auto-scroll";
            this.chkTargetAutoScroll.Checked = true;
            this.chkTargetAutoScroll.Location = new Point(12, 710);
            this.chkTargetAutoScroll.Size = new Size(100, 23);
            this.chkTargetAutoScroll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

            // ========== HOST TAB (same as yours, with adjusted log height) ==========
            this.tabHost.Controls.Add(this.separatorLine);
            this.tabHost.Controls.Add(this.cmbHostIPs);
            this.tabHost.Controls.Add(this.txtHostPort);
            this.tabHost.Controls.Add(this.txtHostKey);
            this.tabHost.Controls.Add(this.txtTargetIP);
            this.tabHost.Controls.Add(this.btnLaunchWinDbg);
            this.tabHost.Controls.Add(this.btnRefreshIPs);
            this.tabHost.Controls.Add(this.btnExportLog);
            this.tabHost.Controls.Add(this.btnFetchKey);
            this.tabHost.Controls.Add(this.btnCopyKeyHost);
            this.tabHost.Controls.Add(this.dgvDiscovered);
            this.tabHost.Controls.Add(this.txtHostLog);
            this.tabHost.Controls.Add(this.lblHostRef);
            this.tabHost.Controls.Add(this.lblHostPort);
            this.tabHost.Controls.Add(this.lblHostKey);
            this.tabHost.Controls.Add(this.lblTargetIPLabel);
            this.tabHost.Controls.Add(this.chkHostAutoScroll);
            this.tabHost.Text = "Host Machine (WinDbg)";
            this.tabHost.UseVisualStyleBackColor = true;

            // Host labels
            this.lblHostRef.Text = "Host IP (reference):";
            this.lblHostRef.Location = new Point(12, 15);
            this.lblHostRef.Size = new Size(120, 23);
            this.lblHostRef.TextAlign = ContentAlignment.MiddleRight;

            this.lblHostPort.Text = "Port:";
            this.lblHostPort.Location = new Point(12, 50);
            this.lblHostPort.Size = new Size(40, 23);
            this.lblHostPort.TextAlign = ContentAlignment.MiddleRight;

            this.lblHostKey.Text = "Key (from target):";
            this.lblHostKey.Location = new Point(150, 50);
            this.lblHostKey.Size = new Size(110, 23);
            this.lblHostKey.TextAlign = ContentAlignment.MiddleRight;

            this.lblTargetIPLabel.Text = "Target IP:";
            this.lblTargetIPLabel.Location = new Point(12, 100);
            this.lblTargetIPLabel.Size = new Size(70, 23);
            this.lblTargetIPLabel.TextAlign = ContentAlignment.MiddleRight;

            // Host controls
            this.cmbHostIPs.Location = new Point(140, 15);
            this.cmbHostIPs.Size = new Size(160, 23);
            this.cmbHostIPs.DropDownStyle = ComboBoxStyle.DropDownList;

            this.btnRefreshIPs.Text = "Refresh IPs";
            this.btnRefreshIPs.Location = new Point(310, 13);
            this.btnRefreshIPs.Size = new Size(100, 27);
            this.btnRefreshIPs.Click += new EventHandler(this.btnRefreshIPs_Click);

            this.txtHostPort.Location = new Point(60, 50);
            this.txtHostPort.Size = new Size(80, 23);
            this.txtHostPort.Text = "50005";

            this.txtHostKey.Location = new Point(270, 50);
            this.txtHostKey.Size = new Size(220, 23);

            this.txtTargetIP.Location = new Point(90, 100);
            this.txtTargetIP.Size = new Size(150, 23);

            this.btnFetchKey.Text = "Fetch Key from Target";
            this.btnFetchKey.Location = new Point(260, 98);
            this.btnFetchKey.Size = new Size(150, 27);
            this.btnFetchKey.Click += new EventHandler(this.btnFetchKey_Click);

            this.btnLaunchWinDbg.Text = "Launch WinDbg";
            this.btnLaunchWinDbg.Location = new Point(510, 48);
            this.btnLaunchWinDbg.Size = new Size(120, 27);
            this.btnLaunchWinDbg.Click += new EventHandler(this.btnLaunchWinDbg_Click);

            this.btnExportLog.Text = "Export Log";
            this.btnExportLog.Location = new Point(650, 48);
            this.btnExportLog.Size = new Size(100, 27);
            this.btnExportLog.Click += new EventHandler(this.btnExportLog_Click);

            this.btnCopyKeyHost.Text = "Copy Selected Key";
            this.btnCopyKeyHost.Location = new Point(420, 160);
            this.btnCopyKeyHost.Size = new Size(150, 27);
            this.btnCopyKeyHost.Click += new EventHandler(this.btnCopyKeyHost_Click);

            this.dgvDiscovered.Location = new Point(12, 135);
            this.dgvDiscovered.Size = new Size(400, 120);
            this.dgvDiscovered.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscovered.MultiSelect = false;
            this.dgvDiscovered.ReadOnly = true;
            this.dgvDiscovered.AllowUserToAddRows = false;
            this.dgvDiscovered.RowHeadersVisible = false;

            this.separatorLine.BackColor = SystemColors.ControlDark;
            this.separatorLine.Height = 2;
            this.separatorLine.Location = new Point(12, 85);
            this.separatorLine.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.separatorLine.Width = 926;  // fixed width to avoid stretching

            // Host log (RichTextBox)
            this.txtHostLog.Location = new Point(5, 270);
            this.txtHostLog.Size = new Size(920, 420);   
            this.txtHostLog.Multiline = true;
            this.txtHostLog.ScrollBars = RichTextBoxScrollBars.Vertical;
            this.txtHostLog.ReadOnly = true;
            this.txtHostLog.WordWrap = true;
            this.txtHostLog.BackColor = SystemColors.Window;

            // Host auto-scroll checkbox
            this.chkHostAutoScroll.Text = "Auto-scroll";
            this.chkHostAutoScroll.Checked = true;
            this.chkHostAutoScroll.Location = new Point(12, 710);
            this.chkHostAutoScroll.Size = new Size(100, 23);
            this.chkHostAutoScroll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

            // ==================================================
            // ABOUT TAB
            // ==================================================
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;

            // About RichTextBox (scrollable description)
            this.txtAbout.Dock = DockStyle.Fill;
            this.txtAbout.ReadOnly = true;
            this.txtAbout.ScrollBars = RichTextBoxScrollBars.Vertical;
            this.txtAbout.WordWrap = true;
            this.txtAbout.BackColor = SystemColors.Window;
            this.txtAbout.Text = 
                "KDNET Helper Tool\n" +
                "=================\n\n" +
                "This application simplifies setting up kernel debugging (KDNET) between two Windows machines.\n\n" +
                "What it does:\n" +
                "• Configures the target machine for KDNET and generates a debugging key.\n" +
                "• Optionally shares the key over a temporary network share (auto‑cleaned on next boot).\n" +
                "• On the host machine, retrieves the key and launches WinDbg with the correct parameters.\n" +
                "• Includes helper buttons for BitLocker and Secure Boot (use with caution).\n\n" +
                "Required files (Redist folder):\n" +
                "• Redist\\x64\\kdnet.exe (or x86\\kdnet.exe)\n" +
                "• Redist\\x64\\VerifiedNICList.xml (or x86\\...)\n" +
                "If these are not present, the tool falls back to Windows SDK locations or prompts manually.\n\n" +
                "Network share credentials (temporary):\n" +
                "• User: KDNETHELPER\n" +
                "• Password: KdnetH1!\n" +
                "• Share: C:\\KDNETHELPERKEY (cleaned up on next boot)\n\n" +
                "Logs are shown in the Target and Host tabs.\n\n" +
                "Made by Liams Electronics Lab\n\n" +
                "If you liked this project, consider following on YouTube or GitHub!\n";

            // YouTube LinkLabel
            this.linkYouTube.Text = "YouTube Channel (Slot1Gamer)";
            this.linkYouTube.Links.Add(0, this.linkYouTube.Text.Length, "https://www.youtube.com/@Slot1Gamer");
            this.linkYouTube.AutoSize = true;
            this.linkYouTube.LinkClicked += (s, e) => System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = e.Link.LinkData.ToString(), UseShellExecute = true });

            // GitHub LinkLabel
            this.linkGitHub.Text = "GitHub Repository (Liams-Electronics-Lab)";
            this.linkGitHub.Links.Add(0, this.linkGitHub.Text.Length, "https://github.com/Liams-Electronics-Lab");
            this.linkGitHub.AutoSize = true;
            this.linkGitHub.LinkClicked += (s, e) => System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = e.Link.LinkData.ToString(), UseShellExecute = true });

            // Layout for About tab: put the two LinkLabels at the bottom, RichTextBox fills above
            this.tabAbout.Controls.Add(this.txtAbout);
            this.tabAbout.Controls.Add(this.linkYouTube);
            this.tabAbout.Controls.Add(this.linkGitHub);

            // Position links at bottom left
            this.linkYouTube.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.linkGitHub.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.linkYouTube.Location = new Point(12, this.tabAbout.ClientSize.Height - 45);
            this.linkGitHub.Location = new Point(12, this.tabAbout.ClientSize.Height - 25);

            // Bring links to front so they are visible over the RichTextBox
            this.linkYouTube.BringToFront();
            this.linkGitHub.BringToFront();

            // ==================================================
            // FORM
            // ==================================================
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(950, 750);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new Size(950, 750);
            this.Text = "KDNET Helper Tool";
            this.Load += new EventHandler(this.Form1_Load);
            this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);

            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscovered)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabTarget.ResumeLayout(false);
            this.tabTarget.PerformLayout();
            this.tabHost.ResumeLayout(false);
            this.tabHost.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}