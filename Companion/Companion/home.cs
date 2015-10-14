using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Companion
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Opens Server Browser Window
            Server_Browser sb = new Server_Browser();
            sb.ShowDialog();
        }

        private void networkTools_Click(object sender, EventArgs e)
        {
            //Opens Server Browser Window
            Network_Tools nt = new Network_Tools();
            nt.ShowDialog();
        }

        private void buttonTestSpeed_Click(object sender, EventArgs e)
        {
            labelSpeedResult.Text = "Testing...";

            const string tempfile = "tempfile.tmp";
            System.Net.WebClient webClient = new System.Net.WebClient();

            Console.WriteLine("Downloading file....");

            System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();
            webClient.DownloadFile("http://mirror.internode.on.net/pub/test/10meg.test", tempfile);
            sw.Stop();

            FileInfo fileInfo = new FileInfo(tempfile);
            long speed = fileInfo.Length / sw.Elapsed.Seconds;
            float speedMbps = speed / 1024;

            labelSpeedResult.Text = "Speed: " + speedMbps.ToString("N0") + " kbps";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.labelTimeVal.Text = string.Format("{0:HH:mm:ss tt}", DateTime.Now);
        }

        private void timetable_Click(object sender, EventArgs e)
        {
            //Opens Timetable Window
            Timetable tt = new Timetable();
            tt.ShowDialog();
        }
    }
}
