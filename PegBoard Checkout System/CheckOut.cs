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
            List<string> outItems = new List<string>();
            List<string> inItems = new List<string>()
;
            foreach (string item in Properties.Settings.Default.ItemStatus)
            {
                string[] parts = item.Split('⎖');
                string status = parts[1];
                if (status == "In") { inItems.Add(ItemManagementSystem.GetName(parts[0])); continue; }
                outItems.Add(ItemManagementSystem.GetName(parts[0]));
            }
            foreach (string item in Properties.Settings.Default.Items)
            {
                string[] parts = item.Split('⎖');
                if (inItems.Contains(parts[1])) { cbItem.Items.Add(parts[1]); continue;  }
                if (!outItems.Contains(parts[1]))  cbItem.Items.Add(parts[1]);
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            foreach (string item in Properties.Settings.Default.Items)
            {
                string[] data = item.Split('⎖');
                string id = data[0];
                string name = data[1];
                if (name == cbItem.Text)
                {
                    ItemManagementSystem.CheckOut(id, txtReason.Text, dtpMoment.Text);
                    MessageBox.Show("Successfully Checked Out " + name);
                    Close();
                    return;
                }
            }
        }
    }
}
