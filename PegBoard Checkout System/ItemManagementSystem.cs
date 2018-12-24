using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PegBoard_Checkout_System
{
    static class ItemManagementSystem
    {
        public static void CreateItem(string id, string name, string location, string description, int index = -1)
        {
            if (index == -1)
            {
                Properties.Settings.Default.Items.Add(id + "⎖" + name + "⎖" + location + "⎖" + description);
            }
            else
            {
                Properties.Settings.Default.Items.Insert(index, id + "⎖" + name + "⎖" + location + "⎖" + description);
            }
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }

        public static void RemoveItem(string givenid)
        {
            foreach (string item in Properties.Settings.Default.Items)
            {
                string id = item.Split('⎖')[0];
                if (id == givenid)
                {
                    Properties.Settings.Default.Items.Remove(item);
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Reload();
                    return;
                }
            }
            
        }

        public static void EditItem(string id, string name, string location, string description, int index)
        {
            RemoveItem(id);
            CreateItem(id, name, location, description, index);
        }

        public static List<string> GetNames()
        {
            List<string> names = new List<string>();
            foreach (string item in Properties.Settings.Default.Items)
            {
                string[] parts = item.Split('⎖');
                string name = parts[1];
                names.Add(name);
            }
            return names;
        }

        public static void CheckOut(string id, string reason, string date)
        {
            foreach (string item in Properties.Settings.Default.ItemStatus)
            {
                string curid = item.Split('⎖')[0];
                if (curid == id)
                {
                    Properties.Settings.Default.ItemStatus.Remove(item);
                    Properties.Settings.Default.ItemStatus.Add(id + "⎖Out⎖" + reason + "⎖" + date);
                    updateLog(id, reason, date, "Out");
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Reload();
                    return;
                }
            }
            Properties.Settings.Default.ItemStatus.Add(id + "⎖Out⎖" + reason + "⎖" + date);
            updateLog(id, reason, date, "Out");
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }

        public static void CheckIn(string id, string reason, string date)
        {
            foreach (string item in Properties.Settings.Default.ItemStatus)
            {
                string curid = item.Split('⎖')[0];
                if (curid == id)
                {
                    Properties.Settings.Default.ItemStatus.Remove(item);
                    Properties.Settings.Default.ItemStatus.Add(id + "⎖In⎖" + reason + "⎖" + date);
                    updateLog(id, reason, date, "In");
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Reload();
                    return;
                }
            }
            Properties.Settings.Default.ItemStatus.Add(id + "⎖In⎖" + reason + "⎖" + date);
            updateLog(id, reason, date, "In");
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }

        public static void updateLog(string id, string reason, string date, string status)
        {
            foreach (string item in Properties.Settings.Default.ItemLog)
            {
                string curid = item.Split('⎖')[0];
                if (curid == id)
                {
                    Properties.Settings.Default.ItemLog.Remove(item);
                    Properties.Settings.Default.ItemLog.Add(item + "⎖" + status + "★" + reason + "★" + date);
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Reload();
                    return;
                }
            }
            Properties.Settings.Default.ItemLog.Add(id + "⎖" + status + "★" + reason + "★" + date);
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }
        
        public static string GetName(string id)
        {
            foreach (string item in Properties.Settings.Default.Items)
            {
                string[] parts = item.Split('⎖');
                if (parts[0] == id) return parts[1];
            }
            return null;
        }
    }
}
