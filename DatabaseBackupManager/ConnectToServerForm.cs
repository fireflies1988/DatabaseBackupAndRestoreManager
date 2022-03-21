using Microsoft.Win32;
using System;
using System.Data;
using System.Data.Sql;
using System.Windows.Forms;

namespace DatabaseBackupManager
{
    public partial class ConnectToServerForm : Form
    {
        public ConnectToServerForm()
        {
            InitializeComponent();
        }

        private void ConnectToServerForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoServerNameComboBox();
            comboBoxServerName.SelectedIndex = 0;
            comboBoxServerType.SelectedIndex = 0;
            comboBoxAuthentication.SelectedIndex = 1;
        }

        private void LoadDataIntoServerNameComboBox()
        {
            string serverName = Environment.MachineName;
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        if (instanceName == "MSSQLSERVER")
                        {
                            comboBoxServerName.Items.Add(serverName);
                        }
                        else
                        {
                            comboBoxServerName.Items.Add(serverName + "\\" + instanceName);
                        }
                    }
                }
            }
        }

        private void comboBoxAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAuthentication.SelectedItem.ToString() == "Windows Authentication")
            {
                panelAuthenticationMode.Enabled = false;
                labelLogin.Text = "User name:";
                textBoxLogin.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            }
            else
            {
                panelAuthenticationMode.Enabled = true;
                labelLogin.Text = "Login:";
                textBoxLogin.Text = "";
            }
        }
    }
}
