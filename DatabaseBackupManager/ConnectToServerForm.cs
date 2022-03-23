using Microsoft.Win32;
using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseBackupManager
{
    public partial class ConnectToServerForm : Form
    {
        private MainForm mainForm;

        public ConnectToServerForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
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

        //private void FillListBoxDatabases(SqlConnection connection)
        //{
        //    using (SqlConnection con = connection)
        //    {
        //        string cmdText = "SELECT name FROM sys.databases" +
        //                             " WHERE database_id > 4 AND name != 'distribution' ORDER BY name";
        //        using (SqlCommand cmd = new SqlCommand(cmdText, con))
        //        {
        //            using (SqlDataReader dr = cmd.ExecuteReader())
        //            {
        //                while (dr.Read())
        //                {
        //                    mainForm.listBoxDatabases.Items.Add(dr.GetString(0));
        //                }
        //            }
        //        }
        //        mainForm.toolStripStatusLabelServerNameAndLogin.Text = comboBoxServerName.Text + " - " + textBoxLogin.Text;
        //    }
        //}

        private void FillListBoxDatabases(string connectionString)
        {
            mainForm.userDatabasesTableAdapter.Connection.ConnectionString = connectionString;
            mainForm.userDatabasesTableAdapter.Fill(mainForm.appData.UserDatabases);
            mainForm.toolStripStatusLabelServerNameAndLogin.Text = comboBoxServerName.Text + " - " + textBoxLogin.Text;
        }

        private void comboBoxAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAuthentication.SelectedItem.ToString() == "Windows Authentication")
            {
                panelAuthenticationMode.Enabled = false;
                labelLogin.Text = "User name:";
                textBoxLogin.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                textBoxPassword.Text = "";
            }
            else
            {
                panelAuthenticationMode.Enabled = true;
                labelLogin.Text = "Login:";
                textBoxLogin.Text = "";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            string connectionString;
            if (comboBoxAuthentication.SelectedItem.ToString() == "Windows Authentication")
            {
                connectionString = Database.GetConnectionString(comboBoxServerName.Text);
            }
            else
            {
                connectionString = Database.GetConnectionString(comboBoxServerName.Text, textBoxLogin.Text, textBoxPassword.Text);
            }

            try
            {
                FillListBoxDatabases(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Connect to Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Close();
            mainForm.groupBoxDatabases.Enabled = true;
            mainForm.groupBoxBackupHistory.Enabled = true;
            mainForm.connectToolStripMenuItem.Enabled = false;
            mainForm.disconnectToolStripMenuItem.Enabled = true;
            mainForm.refreshToolStripMenuItem.Enabled = true;
        }
    }
}
