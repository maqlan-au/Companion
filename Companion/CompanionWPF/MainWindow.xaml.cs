using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace CompanionWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

        }

        void timer_Tick(object sender, EventArgs e)
        {
            labelTimeVal.Content = DateTime.Now.ToLongTimeString();
        }

        private void buttonSpeedTest_Click(object sender, RoutedEventArgs e)
        {
            labelSpeedTestVal.Content = "Testing...";

            const string tempfile = "tempfile.tmp";
            System.Net.WebClient webClient = new System.Net.WebClient();

            Console.WriteLine("Downloading file....");

            System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();
            webClient.DownloadFile("http://mirror.internode.on.net/pub/test/10meg.test", tempfile);
            sw.Stop();

            FileInfo fileInfo = new FileInfo(tempfile);
            long speed = fileInfo.Length / sw.Elapsed.Seconds;
            float speedMbps = speed / 1024;

            labelSpeedTestVal.Content = "Speed: " + speedMbps.ToString("N0") + " kbps";
        }
    }
}
