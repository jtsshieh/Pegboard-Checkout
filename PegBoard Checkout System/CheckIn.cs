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
    public partial class CheckIn : Form
    {
        public CheckIn()
        {
            InitializeComponent();
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {
            List<string> outItems = new List<string>();
            List<string> inItems = new List<string>()
;
            foreach (string item in Properties.Settings.Default.ItemStatus)
            {
                string[] parts = item.Split('⎖');
                string status = parts[1];
                if (status == "Out") { outItems.Add(ItemManagementSystem.GetName(parts[0])); continue; }
                inItems.Add(ItemManagementSystem.GetName(parts[0]));
            }
            foreach (string item in Properties.Settings.Default.Items)
            {
                string[] parts = item.Split('⎖');
                if (outItems.Contains(parts[1])) { cbItem.Items.Add(parts[1]); continue; }
                if (!inItems.Contains(parts[1])) cbItem.Items.Add(parts[1]);
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            foreach (string item in Properties.Settings.Default.Items)
            {
                string[] data = item.Split('⎖');
                string id = data[0];
                string name = data[1];
                if (name == cbItem.Text)
                {
                    ItemManagementSystem.CheckIn(id, txtReason.Text, dtpMoment.Text);
                    MessageBox.Show("Successfully Checked In " + name);
                    Close();
                    return;
                }
            }
        }
    }
}
