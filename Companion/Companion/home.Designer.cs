using System;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.networkTools = new System.Windows.Forms.Button();
            this.serverBrowserButton = new System.Windows.Forms.Button();
            this.labelSpeedResult = new System.Windows.Forms.Label();
            this.buttonTestSpeed = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelTimeVal = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timetable = new System.Windows.Forms.Button();
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
            // labelSpeedResult
            // 
            this.labelSpeedResult.AutoSize = true;
            this.labelSpeedResult.Location = new System.Drawing.Point(406, 145);
            this.labelSpeedResult.Name = "labelSpeedResult";
            this.labelSpeedResult.Size = new System.Drawing.Size(54, 13);
            this.labelSpeedResult.TabIndex = 2;
            this.labelSpeedResult.Text = "No Result";
            // 
            // buttonTestSpeed
            // 
            this.buttonTestSpeed.Location = new System.Drawing.Point(325, 140);
            this.buttonTestSpeed.Name = "buttonTestSpeed";
            this.buttonTestSpeed.Size = new System.Drawing.Size(75, 23);
            this.buttonTestSpeed.TabIndex = 3;
            this.buttonTestSpeed.Text = "SpeedTest";
            this.buttonTestSpeed.UseVisualStyleBackColor = true;
            this.buttonTestSpeed.Click += new System.EventHandler(this.buttonTestSpeed_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(21, 145);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(83, 13);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "Current Time:";
            // 
            // labelTimeVal
            // 
            this.labelTimeVal.AutoSize = true;
            this.labelTimeVal.Location = new System.Drawing.Point(106, 145);
            this.labelTimeVal.Name = "labelTimeVal";
            this.labelTimeVal.Size = new System.Drawing.Size(80, 13);
            this.labelTimeVal.TabIndex = 5;
            this.labelTimeVal.Text = "Time Loading...";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timetable
            // 
            this.timetable.Location = new System.Drawing.Point(346, 12);
            this.timetable.Name = "timetable";
            this.timetable.Size = new System.Drawing.Size(161, 103);
            this.timetable.TabIndex = 6;
            this.timetable.Text = "Timetable";
            this.timetable.UseVisualStyleBackColor = true;
            this.timetable.Click += new System.EventHandler(this.timetable_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 178);
            this.Controls.Add(this.timetable);
            this.Controls.Add(this.labelTimeVal);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonTestSpeed);
            this.Controls.Add(this.labelSpeedResult);
            this.Controls.Add(this.serverBrowserButton);
            this.Controls.Add(this.networkTools);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "MaqLAN Companion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button networkTools;
        private System.Windows.Forms.Button serverBrowserButton;
        private System.Windows.Forms.Label labelSpeedResult;
        private System.Windows.Forms.Button buttonTestSpeed;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelTimeVal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button timetable;
    }
}

