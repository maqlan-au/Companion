using System;
using System.IO;
using System.Windows;
using System.Windows.Threading;
using MySql.Data.MySqlClient;
using System.Data;
using System.ComponentModel;
using System.Net;
using System.Windows.Controls;
using System.Diagnostics;
using System.Linq;

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
            //speedtesting = true;
            const string tempfile = "tempfile.tmp";
            System.Net.WebClient webClient = new System.Net.WebClient();

            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

            //System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();
            
            webClient.DownloadFileAsync(new Uri("http://mirror.internode.on.net/pub/test/10meg.test"), tempfile);
            
            //sw.Stop();

            //FileInfo fileInfo = new FileInfo(tempfile);
            //long speed = fileInfo.Length / sw.Elapsed.Seconds;
            //float speedMbps = speed / 1024;

            //labelSpeedTestVal.Content = "Speed: " + speedMbps.ToString("N0") + " kbps";
            

        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressbarSpeedTest.Value = e.ProgressPercentage;
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            //MessageBox.Show("Download completed!");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            labelLastUpdatedVal.Content = DateTime.Now.ToLongTimeString();

            //Change MySQL Connection Details Here
            string connStr = "SERVER=128.199.167.5;" +
                "DATABASE=companion_servers;" +
                "UID=companion;" +
                "PWD=companion;";

            MySqlConnection conn = new MySqlConnection(connStr);

            DataTable dt = new DataTable();

            conn.Open();

            try
            {
                string query = "SELECT * FROM servers ORDER BY name ASC";
                using (MySqlDataAdapter da = new MySqlDataAdapter(query, conn))
                    da.Fill(dt);

                dataServerGrid.ItemsSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(string.Format("An error occurred {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null) conn.Close();
            }
        }
    }
}
