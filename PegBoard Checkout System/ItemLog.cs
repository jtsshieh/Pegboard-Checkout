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
    public partial class ItemLog : Form
    {
        public ItemLog()
        {
            InitializeComponent();
        }

        private void ItemLog_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Items == null)
            {
                Properties.Settings.Default.Items = new ArrayList();
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
            }
            lbItems.Items.Clear();
            lbItems.Items.AddRange(ItemManagementSystem.GetNames().ToArray());
        }

        private void lbItems_SelectedValueChanged(object sender, EventArgs e)
        {
            txtStatus.Clear();
            txtAction.Clear();
            txtReason.Clear();
            txtTime.Clear();
            lbLog.Items.Clear();
            if (lbItems.SelectedIndex == -1) return;
            foreach (string item in Properties.Settings.Default.ItemStatus)
            {
                string[] parts = item.Split('⎖');
                string id = parts[0];
                string status = parts[1];
                bool cont = false;
                foreach (string i in Properties.Settings.Default.Items)
                {
                    string[] sec = i.Split('⎖');
                    string itemId = sec[0];
                    string itemName = sec[1];
                    if (id == itemId && itemName == lbItems.SelectedItem.ToString()) { cont = true; break; }
                }
                if (cont == false) continue;
                
                txtStatus.Text = status;
            }
            foreach (string item in Properties.Settings.Default.ItemLog)
            {
                bool cont = false;
                string[] parts = item.Split('⎖');
                //Current ID
                string id = parts[0];
                
                foreach (string i in Properties.Settings.Default.Items)
                {
                    string[] sec = i.Split('⎖');
                    string itemId = sec[0];
                    string itemName = sec[1];
                    if (itemId == id && itemName == lbItems.SelectedItem.ToString()) { cont = true; break; }
                }

                if (cont == false) continue;
                int cur = 1;
                foreach(string log in parts)
                {
                    if (log == id) continue;
                    string[] fields = log.Split('★');
                    string status = fields[0];
                    string reason = fields[1];
                    string moment = fields[2];

                    lbLog.Items.Insert(0, "Check " + status + "#" + cur);
                    cur++;
                }
            }
        }


        private void lbLog_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbLog.SelectedIndex == -1) return;


            foreach (string item in Properties.Settings.Default.ItemLog)
            {
                bool cont = false;
                string[] parts = item.Split('⎖');
                string id = parts[0];
                foreach (string i in Properties.Settings.Default.Items)
                {
                    string[] sec = i.Split('⎖');
                    string itemId = sec[0];
                    string itemName = sec[1];
                    if (itemId == id && itemName == lbItems.SelectedItem.ToString()) { cont = true; break; }
                }
                int amount = parts.Length - 1;
                int position = amount - lbLog.SelectedIndex;
                if (cont == false) continue;
                int cur = 1;
                foreach (string log in parts)
                {


                    if (log == id) continue;
                    if (cur != position) { cur++; continue; };
                    string[] fields = log.Split('★');
                    string status = fields[0];
                    string reason = fields[1];
                    string moment = fields[2];

                    txtAction.Text = status;
                    txtReason.Text = reason;
                    txtTime.Text = moment;
                    return;

                }
            }
        }
    }
    }
