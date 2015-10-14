namespace Companion
{
    partial class Server_Browser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server_Browser));
            this.dataGridViewGameServers = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGameServers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGameServers
            // 
            this.dataGridViewGameServers.AllowUserToAddRows = false;
            this.dataGridViewGameServers.AllowUserToDeleteRows = false;
            this.dataGridViewGameServers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGameServers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewGameServers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGameServers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewGameServers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGameServers.Name = "dataGridViewGameServers";
            this.dataGridViewGameServers.ReadOnly = true;
            this.dataGridViewGameServers.RowHeadersVisible = false;
            this.dataGridViewGameServers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewGameServers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewGameServers.ShowCellErrors = false;
            this.dataGridViewGameServers.ShowCellToolTips = false;
            this.dataGridViewGameServers.ShowEditingIcon = false;
            this.dataGridViewGameServers.ShowRowErrors = false;
            this.dataGridViewGameServers.Size = new System.Drawing.Size(942, 304);
            this.dataGridViewGameServers.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(441, 371);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // Server_Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(942, 561);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewGameServers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Server_Browser";
            this.Text = "Server_Browser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGameServers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGameServers;
        private System.Windows.Forms.Button buttonRefresh;
    }
}