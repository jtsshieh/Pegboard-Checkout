using System;
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
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            comboBox2.Items.AddRange(ItemManagementSystem.GetNames().ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (string item in Properties.Settings.Default.Items)
            {
                string[] data = item.Split('⎖');
                string id = data[0];
                string name = data[1];
                if (name == comboBox2.Text)
                {
                    ItemManagementSystem.CheckOut(id, textBox2.Text, dateTimePicker2.Text);
                    MessageBox.Show("Successfully Checked Out " + name);
                    Close();
                    return;
                }
            }
        }
    }
}
