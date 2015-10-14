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
    }
}
