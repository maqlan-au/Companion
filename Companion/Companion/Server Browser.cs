﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Companion
{
    public partial class Server_Browser : Form
    {
        public Server_Browser()
        {
            InitializeComponent();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            //Change MySQL Connection Details Here
            string connStr = "SERVER=localhost;" +
                  "DATABASE=maqlan_servers;" +
                  "UID=companion;" +
                  "PWD=companion;";

            MySqlConnection conn = new MySqlConnection(connStr);

            conn.Open();

            MySqlCommand cmd = null;
            DataTable dataTable = new DataTable();

            try
            {
                //Chage select query here for filling data into the table
                string sql = "SELECT * FROM servers ORDER BY name ASC";
                cmd = new MySqlCommand(sql, conn);

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dataTable);
                }

                dataGridViewGameServers.DataSource = dataTable;
                dataGridViewGameServers.DataMember = dataTable.TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null) conn.Close();
            }
        }
    }
}
