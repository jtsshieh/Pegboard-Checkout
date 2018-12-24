using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PegBoard_Checkout_System
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new CheckIn().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CheckOut().ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new ItemEditor().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ItemStatus == null)
            {
                Properties.Settings.Default.ItemStatus = new ArrayList();
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
            }
            if (Properties.Settings.Default.ItemLog == null)
            {
                Properties.Settings.Default.ItemLog = new ArrayList();
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ItemLog().Show();
        }
    }
}
