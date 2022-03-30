using DatabaseBackupManager.Properties;
using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace DatabaseBackupManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Init();
        }

        private void Init()
        {
            //ResourceManager rm = new ResourceManager("DatabaseBackupManager.Properties.Resources", Assembly.GetExecutingAssembly());
            string lang = Utils.ReadResource("lang");
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(lang);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(lang);

            InitializeComponent();
            if (lang == "vi-VN")
            {
                englishToolStripMenuItem.Checked = false;
                tiengVietToolStripMenuItem.Checked = true;
                languageToolStripMenuItem.Text = tiengVietToolStripMenuItem.Text;
            }
        }

        private void changeLanguage(object selectedMenuItem)
        {
            ToolStripMenuItem currentItem = selectedMenuItem as ToolStripMenuItem;
            ((ToolStripMenuItem)currentItem.OwnerItem).DropDownItems.OfType<ToolStripMenuItem>().ToList()
                .ForEach(item =>
                {
                    item.Checked = false;
                });
            currentItem.Checked = true;
            languageToolStripMenuItem.Text = currentItem.Text;
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!englishToolStripMenuItem.Checked)
            {
                changeLanguage(sender);
                Utils.AddOrUpdateResource("lang", "en-US");
                if (MessageBox.Show(this, "Ngôn ngữ hiển thị đã được thay đổi. Bạn phải khởi động lại ứng dụng để các thay đổi có hiệu lực." +
                    "\nBạn có muốn khởi động lại nó bây giờ không?", "Thay đổi ngôn ngữ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Application.Restart();
                }
            }
        }

        private void tiengVietToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!tiengVietToolStripMenuItem.Checked)
            {
                changeLanguage(sender);
                Utils.AddOrUpdateResource("lang", "vi-VN");
                if (MessageBox.Show(this, "Display language has been changed. You must restart the application for changes to take effect." +
                    "\nDo you want to restart it now?", "Change language", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Application.Restart();
                }
            }
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConnectToServerForm(this).ShowDialog();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Init();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxBackupHistory.Visible = false;
            treeViewExplorer.Nodes[0].Nodes[0].Nodes.Clear();
            treeViewExplorer.Nodes[0].Nodes[1].Nodes.Clear();
            PopulateTreeViewExplorer();
        }

        public void PopulateTreeViewExplorer()
        {
            backup_devicesTableAdapter.Fill(appData.backup_devices);
            foreach (DataRow row in userDatabasesTableAdapter.GetData().Rows)
            {
                treeViewExplorer.Nodes[0].Nodes[0].Nodes.Add(row["name"].ToString(), row["name"].ToString(), 2, 2);
            }

            foreach (DataRow row in backup_devicesTableAdapter.GetData().Rows)
            {
                treeViewExplorer.Nodes[0].Nodes[1].Nodes.Add(row["name"].ToString(), row["name"].ToString(), 3, 3);
            }
        }

        public void PopulateTreeViewExplorer(string connectionString)
        {
            userDatabasesTableAdapter.Connection.ConnectionString = connectionString;
            backup_devicesTableAdapter.Connection.ConnectionString = connectionString;
            backup_devicesTableAdapter.Fill(appData.backup_devices);

            foreach (DataRow row in userDatabasesTableAdapter.GetData().Rows)
            {
                //TreeNode node = new TreeNode(row["name"].ToString(), 2, 2);
                treeViewExplorer.Nodes[0].Nodes[0].Nodes.Add(row["name"].ToString(), row["name"].ToString(), 2, 2);
            }

            foreach (DataRow row in backup_devicesTableAdapter.GetData().Rows)
            {
                treeViewExplorer.Nodes[0].Nodes[1].Nodes.Add(row["name"].ToString(), row["name"].ToString(), 3, 3);
            }
        }

        private void treeViewExplorer_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewExplorer.SelectedNode.Parent != null
                && treeViewExplorer.SelectedNode.Parent.Name == "NodeDatabases")
            {
                string databaseName = treeViewExplorer.SelectedNode.Text;
                string backupDeviceName = "bd_" + databaseName;
                groupBoxBackupHistory.Visible = true;
                backupHistoryTableAdapter.Connection.ConnectionString = SqlServer.ConnectionString;
                backupHistoryTableAdapter.Fill(appData.BackupHistory, backupDeviceName, databaseName);

                if (!BackupDeviceExists(backupDeviceName))
                {
                    newBackupDeviceToolStripMenuItem.Enabled = true;
                    backupToolStripMenuItem.Enabled = false;
                    restoreToolStripMenuItem.Enabled = false;
                }
                else
                {
                    newBackupDeviceToolStripMenuItem.Enabled = false;
                    backupToolStripMenuItem.Enabled = true;
                    restoreToolStripMenuItem.Enabled = backupHistoryBindingSource.Count > 0;
                }
            }
            else
            {
                groupBoxBackupHistory.Visible = false;
                newBackupDeviceToolStripMenuItem.Enabled = false;
                backupToolStripMenuItem.Enabled = false;
                restoreToolStripMenuItem.Enabled = false;
            }
        }

        public void RefreshBackupHistoryTable(string backupDeviceName, string databaseName)
        {
            backupHistoryTableAdapter.Fill(appData.BackupHistory, backupDeviceName, databaseName);
            restoreToolStripMenuItem.Enabled = backupHistoryBindingSource.Count > 0;
        }

        private bool BackupDeviceExists(string backupDeviceName)
        {
            //foreach (DataRow row in backup_devicesTableAdapter.GetData().Rows)
            //{
            //    if (backupDeviceName == row["name"].ToString())
            //    {
            //        return true;
            //    }
            //}
            //return false;
            return backupDevicesBindingSource.Find("name", backupDeviceName) > -1;
        }

        private void newBackupDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BackupDeviceForm(this).ShowDialog();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BackupForm(this).ShowDialog();
        }
    }
}
