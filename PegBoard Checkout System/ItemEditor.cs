using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PegBoard_Checkout_System
{
    public partial class ItemEditor : Form
    {
        public ItemEditor()
        {
            InitializeComponent();
        }

        private void ItemEditor_Load(object sender, EventArgs e)
        {
            listPopulate();
        }

        private void listPopulate()
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


        private void operationCompleted()
        {
            lblStatus.Text = "Operation Completed";
            lblStatus.ForeColor = Color.Green;
            tmStatus.Start();
        }

        private void operationFailed()
        {
            lblStatus.Text = "Operation Failed";
            lblStatus.ForeColor = Color.Red;
            tmStatus.Start();
        }

        private void lbItems_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbItems.SelectedIndex == -1) return;
            foreach (string item in Properties.Settings.Default.Items)
            {
                string[] parts = item.Split('⎖');
                string id = parts[0];
                string name = parts[1];
                string location = parts[2];
                string description = parts[3];
                if (name != lbItems.SelectedItem.ToString()) continue;
                txtID.Text = id;
                txtName.Text = name;
                txtLocation.Text = location;
                txtDescription.Text = description;
            }
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int index = 0;
                foreach (string item in Properties.Settings.Default.Items)
                {
                    if (txtID.Text == item.Split('⎖')[0])
                    {
                        ItemManagementSystem.EditItem(txtID.Text, txtName.Text, txtLocation.Text, txtDescription.Text, index);
                        listPopulate();
                        operationCompleted();
                        return;
                    }
                    index++;
                }
                ItemManagementSystem.CreateItem(txtID.Text, txtName.Text, txtLocation.Text, txtDescription.Text);
                listPopulate();
                operationCompleted();
                return;
            }
            catch (Exception ex)
            {
                operationFailed();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (string item in Properties.Settings.Default.Items)
            {
                if (txtID.Text == item.Split('⎖')[0])
                {
                    ItemManagementSystem.RemoveItem(txtID.Text);
                    listPopulate();
                    operationCompleted();
                    return;
                }
            }
            MessageBox.Show("The given id wasn't found. The operation failed.");
            operationFailed();
            listPopulate();
            return;
        }

        private void tmStatus_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = "Awaiting Operation";
            lblStatus.ForeColor = Color.Black;
            tmStatus.Stop();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (lbItems.SelectedIndex == -1) { operationFailed(); return; }
            int index = 0;
            foreach (string item in Properties.Settings.Default.Items)
            {
                if (lbItems.SelectedItem.ToString() == item.Split('⎖')[1])
                {
                    if (index == 0) { operationFailed(); return; }
                    string[] parts = item.Split('⎖');
                    string id = parts[0];
                    string name = parts[1];
                    string location = parts[2];
                    string description = parts[3];
                    ItemManagementSystem.EditItem(id, name, location, description, index - 1);
                    listPopulate();
                    operationCompleted();
                    lbItems.SelectedItem = name;
                    return;
                }
                index++;
            }
            operationFailed();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (lbItems.SelectedIndex == -1) { operationFailed(); return; }
            int index = 0;
            foreach (string item in Properties.Settings.Default.Items)
            {
                if (lbItems.SelectedItem.ToString() == item.Split('⎖')[1])
                {
                    if (index == (lbItems.Items.Count - 1)) { operationFailed(); return; }
                    string[] parts = item.Split('⎖');
                    string id = parts[0];
                    string name = parts[1];
                    string location = parts[2];
                    string description = parts[3];
                    ItemManagementSystem.EditItem(id, name, location, description, index + 1);
                    listPopulate();
                    operationCompleted();
                    lbItems.SelectedItem = name;
                    return;
                }
                index++;
            }
            operationFailed();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtLocation.Clear();
            txtDescription.Clear();
        }
    }
}
