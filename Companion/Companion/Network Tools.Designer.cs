namespace Companion
{
    partial class Network_Tools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Network_Tools));
            this.groupBoxCurrentSettings = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelHostname = new System.Windows.Forms.Label();
            this.labelHostnameVal = new System.Windows.Forms.Label();
            this.labelIPs = new System.Windows.Forms.Label();
            this.listBoxIPs = new System.Windows.Forms.ListBox();
            this.groupBoxConnectivity = new System.Windows.Forms.GroupBox();
            this.groupBoxIPControl = new System.Windows.Forms.GroupBox();
            this.groupBoxDNSControl = new System.Windows.Forms.GroupBox();
            this.buttonIPConfig = new System.Windows.Forms.Button();
            this.buttonPingGoogle = new System.Windows.Forms.Button();
            this.buttonDNStoDHCP = new System.Windows.Forms.Button();
            this.buttonIPtoDHCP = new System.Windows.Forms.Button();
            this.buttonFlushDNS = new System.Windows.Forms.Button();
            this.buttonIPRenew = new System.Windows.Forms.Button();
            this.groupBoxCurrentSettings.SuspendLayout();
            this.groupBoxConnectivity.SuspendLayout();
            this.groupBoxIPControl.SuspendLayout();
            this.groupBoxDNSControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCurrentSettings
            // 
            this.groupBoxCurrentSettings.Controls.Add(this.listBoxIPs);
            this.groupBoxCurrentSettings.Controls.Add(this.labelIPs);
            this.groupBoxCurrentSettings.Controls.Add(this.labelHostnameVal);
            this.groupBoxCurrentSettings.Controls.Add(this.labelHostname);
            this.groupBoxCurrentSettings.Controls.Add(this.button1);
            this.groupBoxCurrentSettings.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCurrentSettings.Name = "groupBoxCurrentSettings";
            this.groupBoxCurrentSettings.Size = new System.Drawing.Size(368, 118);
            this.groupBoxCurrentSettings.TabIndex = 0;
            this.groupBoxCurrentSettings.TabStop = false;
            this.groupBoxCurrentSettings.Text = "Current Settings";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 86);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get/Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelHostname
            // 
            this.labelHostname.AutoSize = true;
            this.labelHostname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHostname.Location = new System.Drawing.Point(6, 34);
            this.labelHostname.Name = "labelHostname";
            this.labelHostname.Size = new System.Drawing.Size(67, 13);
            this.labelHostname.TabIndex = 1;
            this.labelHostname.Text = "Hostname:";
            // 
            // labelHostnameVal
            // 
            this.labelHostnameVal.AutoSize = true;
            this.labelHostnameVal.Location = new System.Drawing.Point(79, 34);
            this.labelHostnameVal.Name = "labelHostnameVal";
            this.labelHostnameVal.Size = new System.Drawing.Size(0, 13);
            this.labelHostnameVal.TabIndex = 2;
            // 
            // labelIPs
            // 
            this.labelIPs.AutoSize = true;
            this.labelIPs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIPs.Location = new System.Drawing.Point(6, 70);
            this.labelIPs.Name = "labelIPs";
            this.labelIPs.Size = new System.Drawing.Size(86, 13);
            this.labelIPs.TabIndex = 3;
            this.labelIPs.Text = "IP Address(s):";
            // 
            // listBoxIPs
            // 
            this.listBoxIPs.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBoxIPs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxIPs.FormattingEnabled = true;
            this.listBoxIPs.Location = new System.Drawing.Point(98, 70);
            this.listBoxIPs.Name = "listBoxIPs";
            this.listBoxIPs.Size = new System.Drawing.Size(93, 39);
            this.listBoxIPs.TabIndex = 4;
            // 
            // groupBoxConnectivity
            // 
            this.groupBoxConnectivity.Controls.Add(this.buttonPingGoogle);
            this.groupBoxConnectivity.Controls.Add(this.buttonIPConfig);
            this.groupBoxConnectivity.Location = new System.Drawing.Point(12, 136);
            this.groupBoxConnectivity.Name = "groupBoxConnectivity";
            this.groupBoxConnectivity.Size = new System.Drawing.Size(368, 118);
            this.groupBoxConnectivity.TabIndex = 1;
            this.groupBoxConnectivity.TabStop = false;
            this.groupBoxConnectivity.Text = "Connectivity";
            // 
            // groupBoxIPControl
            // 
            this.groupBoxIPControl.Controls.Add(this.buttonIPtoDHCP);
            this.groupBoxIPControl.Controls.Add(this.buttonIPRenew);
            this.groupBoxIPControl.Location = new System.Drawing.Point(12, 260);
            this.groupBoxIPControl.Name = "groupBoxIPControl";
            this.groupBoxIPControl.Size = new System.Drawing.Size(368, 118);
            this.groupBoxIPControl.TabIndex = 2;
            this.groupBoxIPControl.TabStop = false;
            this.groupBoxIPControl.Text = "IP Control";
            // 
            // groupBoxDNSControl
            // 
            this.groupBoxDNSControl.Controls.Add(this.buttonDNStoDHCP);
            this.groupBoxDNSControl.Controls.Add(this.buttonFlushDNS);
            this.groupBoxDNSControl.Location = new System.Drawing.Point(12, 384);
            this.groupBoxDNSControl.Name = "groupBoxDNSControl";
            this.groupBoxDNSControl.Size = new System.Drawing.Size(368, 118);
            this.groupBoxDNSControl.TabIndex = 2;
            this.groupBoxDNSControl.TabStop = false;
            this.groupBoxDNSControl.Text = "DNS Control";
            // 
            // buttonIPConfig
            // 
            this.buttonIPConfig.Location = new System.Drawing.Point(6, 19);
            this.buttonIPConfig.Name = "buttonIPConfig";
            this.buttonIPConfig.Size = new System.Drawing.Size(165, 93);
            this.buttonIPConfig.TabIndex = 0;
            this.buttonIPConfig.Text = "IP Config";
            this.buttonIPConfig.UseVisualStyleBackColor = true;
            this.buttonIPConfig.Click += new System.EventHandler(this.buttonIPConfig_Click);
            // 
            // buttonPingGoogle
            // 
            this.buttonPingGoogle.Location = new System.Drawing.Point(197, 19);
            this.buttonPingGoogle.Name = "buttonPingGoogle";
            this.buttonPingGoogle.Size = new System.Drawing.Size(165, 93);
            this.buttonPingGoogle.TabIndex = 1;
            this.buttonPingGoogle.Text = "Ping google.com";
            this.buttonPingGoogle.UseVisualStyleBackColor = true;
            this.buttonPingGoogle.Click += new System.EventHandler(this.buttonPingGoogle_Click);
            // 
            // buttonDNStoDHCP
            // 
            this.buttonDNStoDHCP.Location = new System.Drawing.Point(197, 19);
            this.buttonDNStoDHCP.Name = "buttonDNStoDHCP";
            this.buttonDNStoDHCP.Size = new System.Drawing.Size(165, 93);
            this.buttonDNStoDHCP.TabIndex = 2;
            this.buttonDNStoDHCP.Text = "DNS to DHCP";
            this.buttonDNStoDHCP.UseVisualStyleBackColor = true;
            this.buttonDNStoDHCP.Click += new System.EventHandler(this.buttonDNStoDHCP_Click);
            // 
            // buttonIPtoDHCP
            // 
            this.buttonIPtoDHCP.Location = new System.Drawing.Point(197, 19);
            this.buttonIPtoDHCP.Name = "buttonIPtoDHCP";
            this.buttonIPtoDHCP.Size = new System.Drawing.Size(165, 93);
            this.buttonIPtoDHCP.TabIndex = 3;
            this.buttonIPtoDHCP.Text = "Set IP to DHCP";
            this.buttonIPtoDHCP.UseVisualStyleBackColor = true;
            this.buttonIPtoDHCP.Click += new System.EventHandler(this.buttonIPtoDHCP_Click);
            // 
            // buttonFlushDNS
            // 
            this.buttonFlushDNS.Location = new System.Drawing.Point(6, 19);
            this.buttonFlushDNS.Name = "buttonFlushDNS";
            this.buttonFlushDNS.Size = new System.Drawing.Size(165, 93);
            this.buttonFlushDNS.TabIndex = 4;
            this.buttonFlushDNS.Text = "Flush DNS";
            this.buttonFlushDNS.UseVisualStyleBackColor = true;
            this.buttonFlushDNS.Click += new System.EventHandler(this.buttonFlushDNS_Click);
            // 
            // buttonIPRenew
            // 
            this.buttonIPRenew.Location = new System.Drawing.Point(6, 19);
            this.buttonIPRenew.Name = "buttonIPRenew";
            this.buttonIPRenew.Size = new System.Drawing.Size(165, 93);
            this.buttonIPRenew.TabIndex = 5;
            this.buttonIPRenew.Text = "Renew IP";
            this.buttonIPRenew.UseVisualStyleBackColor = true;
            this.buttonIPRenew.Click += new System.EventHandler(this.buttonIPRenew_Click);
            // 
            // Network_Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 518);
            this.Controls.Add(this.groupBoxIPControl);
            this.Controls.Add(this.groupBoxDNSControl);
            this.Controls.Add(this.groupBoxConnectivity);
            this.Controls.Add(this.groupBoxCurrentSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Network_Tools";
            this.Text = "Network Tools";
            this.groupBoxCurrentSettings.ResumeLayout(false);
            this.groupBoxCurrentSettings.PerformLayout();
            this.groupBoxConnectivity.ResumeLayout(false);
            this.groupBoxIPControl.ResumeLayout(false);
            this.groupBoxDNSControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCurrentSettings;
        private System.Windows.Forms.Label labelHostnameVal;
        private System.Windows.Forms.Label labelHostname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxIPs;
        private System.Windows.Forms.Label labelIPs;
        private System.Windows.Forms.GroupBox groupBoxConnectivity;
        private System.Windows.Forms.Button buttonPingGoogle;
        private System.Windows.Forms.Button buttonIPConfig;
        private System.Windows.Forms.GroupBox groupBoxIPControl;
        private System.Windows.Forms.Button buttonIPtoDHCP;
        private System.Windows.Forms.Button buttonIPRenew;
        private System.Windows.Forms.GroupBox groupBoxDNSControl;
        private System.Windows.Forms.Button buttonDNStoDHCP;
        private System.Windows.Forms.Button buttonFlushDNS;
    }
}