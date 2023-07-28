using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USBEnableDisable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        RegistryKey Regkey, RegKey2;
        Int32 rValue, rsvalue, Gvalue, tvalue;
        string Regpath = "System\\CurrentControlSet\\Services\\USBSTOR";
        string ReadAndWriteRegPath2 = "System\\CurrentControlSet\\Control";
        string ReadAndWriteRegPath = "System\\CurrentControlSet\\Control\\StorageDevicePolicies";

        #region Show Device List
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void buttonCheckDevice_Click(object sender, EventArgs e)
        {
            {
                ManagementObjectCollection collection;
                using (var finddevice = new ManagementObjectSearcher(@"Select * From Win32_USBHub"))
                    collection = finddevice.Get();
                foreach (var device in collection)
                {
                    listBox1.Items.Add(device.GetPropertyValue("DeviceID"));
                    listBox1.Items.Add(device.GetPropertyValue("Description"));
                }
            }
        }

        #endregion

        #region Enable/Disable
        private void radioButtonDisable_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            rValue = 4;
        }
        private void radioButtonEnable_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            rValue = 3;
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            Regkey = Registry.LocalMachine.OpenSubKey(Regpath, true);
            Regkey.SetValue("Start", rValue);
            if (groupBox1.Enabled == true)
            {
                RegKey2 = Registry.LocalMachine.OpenSubKey(ReadAndWriteRegPath2, true);
                RegKey2.CreateSubKey("StorageDevicePolicies");
                RegKey2 = Registry.LocalMachine.OpenSubKey(ReadAndWriteRegPath, true);
                RegKey2.SetValue("WriteProtect", rsvalue);
            }
            if ((rValue == 3) && (rsvalue == 1))
            {
                MessageBox.Show("USB Port is enabled and read-only is enabled.");
            }
            else if ((rValue == 3) && (rsvalue == 0))
            {
                MessageBox.Show("USB Port is enabled and read and write is enabled.");
            }
            else
            {
                MessageBox.Show("USB Port is disabled.");
            }
        }
        #endregion

        #region Read-Only/Read And Write
        private void Form1Main_Load(object sender, EventArgs e)
        {
            isAdmin = IsUserAnAdmin();
            if (isAdmin == false)
            {
                MessageBox.Show("You don't have proper privileges level to make changes, administrators privileges are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            else
            {
                Regkey = Registry.LocalMachine.OpenSubKey(Regpath, true);
                Gvalue = Convert.ToInt32(Regkey.GetValue("Start"));

                if (Gvalue == 3)
                {
                    radioButtonEnable.Checked = true;
                }
                else if (Gvalue == 4)
                {
                    radioButtonDisable.Checked = true;
                }
                RegKey2 = Registry.LocalMachine.OpenSubKey(ReadAndWriteRegPath, true);
                try
                {
                    tvalue = Convert.ToInt32(RegKey2.GetValue("WriteProtect"));
                    if (tvalue == 1)
                    {
                        radioButtonReadOnly.Checked = true;
                    }
                    else if (tvalue == 0)
                    {
                        radioButtonReadAndWrite.Checked = true;
                    }
                }
                catch (NullReferenceException) { }
            }
        }

        private void radioButtonreadonly_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButtonReadAndWrite_CheckedChanged(object sender, EventArgs e)
        {
            rsvalue = 0;
        }
        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        bool isAdmin;
        [DllImport("shell32")]
        static extern bool IsUserAnAdmin();
        #endregion
    }
}
