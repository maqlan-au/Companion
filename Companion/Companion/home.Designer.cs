namespace Companion
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.networkTools = new System.Windows.Forms.Button();
            this.serverBrowserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // networkTools
            // 
            this.networkTools.Location = new System.Drawing.Point(179, 12);
            this.networkTools.Name = "networkTools";
            this.networkTools.Size = new System.Drawing.Size(161, 103);
            this.networkTools.TabIndex = 0;
            this.networkTools.Text = "Network Tools";
            this.networkTools.UseVisualStyleBackColor = true;
            this.networkTools.Click += new System.EventHandler(this.networkTools_Click);
            // 
            // serverBrowserButton
            // 
            this.serverBrowserButton.Location = new System.Drawing.Point(12, 12);
            this.serverBrowserButton.Name = "serverBrowserButton";
            this.serverBrowserButton.Size = new System.Drawing.Size(161, 103);
            this.serverBrowserButton.TabIndex = 1;
            this.serverBrowserButton.Text = "Server Browser";
            this.serverBrowserButton.UseVisualStyleBackColor = true;
            this.serverBrowserButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 128);
            this.Controls.Add(this.serverBrowserButton);
            this.Controls.Add(this.networkTools);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "MaqLAN Companion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button networkTools;
        private System.Windows.Forms.Button serverBrowserButton;
    }
}

