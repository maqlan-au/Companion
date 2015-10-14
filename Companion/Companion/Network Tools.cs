using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Companion
{
    public partial class Network_Tools : Form
    {
        public Network_Tools()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxIPs.Items.Clear();

            //IP addressing
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                    //MessageBox.Show(localIP);
                    listBoxIPs.Items.Add(localIP);
                }
            }

            //Hostname
            String hostName = Dns.GetHostName();
            labelHostnameVal.Text = hostName;
        }

        private void buttonIPConfig_Click(object sender, EventArgs e)
        {
            string actionIpconfig = "/K ipconfig";
            System.Diagnostics.Process.Start("CMD.exe", actionIpconfig);
        }

        private void buttonPingGoogle_Click(object sender, EventArgs e)
        {
            string actionPingGoogle = "/K ping google.com";
            System.Diagnostics.Process.Start("CMD.exe", actionPingGoogle);
        }

        private void buttonIPRenew_Click(object sender, EventArgs e)
        {
            string actionRenewIp = "/C ipconfig /renew";
            System.Diagnostics.Process.Start("CMD.exe", actionRenewIp);
        }

        private void buttonIPtoDHCP_Click(object sender, EventArgs e)
        {
            string actionSetIpToDhcp = "/C netsh interface ip set address name=\"Local Area Connection\" source=dhcp";
            System.Diagnostics.Process.Start("CMD.exe", actionSetIpToDhcp);
        }

        private void buttonFlushDNS_Click(object sender, EventArgs e)
        {
            string actionFlushDns = "/C ipconfig /flushdns";
            System.Diagnostics.Process.Start("CMD.exe", actionFlushDns);
        }

        private void buttonDNStoDHCP_Click(object sender, EventArgs e)
        {
            string actionSetDnsToDhcp = "/C netsh interface ip set dnsservers name=\"Local Area Connection\" source=dhcp";
            System.Diagnostics.Process.Start("CMD.exe", actionSetDnsToDhcp);
        }
    }
}
