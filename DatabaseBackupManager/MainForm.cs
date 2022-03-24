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
            treeViewExplorer.Nodes[0].Nodes[0].Nodes.Clear();
            treeViewExplorer.Nodes[0].Nodes[1].Nodes.Clear();
            PopulateTreeViewExplorer();
        }

        public void PopulateTreeViewExplorer()
        {
            foreach (DataRow row in userDatabasesTableAdapter.GetData().Rows)
            {
                TreeNode node = new TreeNode(row["name"].ToString(), 2, 2);
                treeViewExplorer.Nodes[0].Nodes[0].Nodes.Add(node);
            }

            foreach (DataRow row in backup_devicesTableAdapter.GetData().Rows)
            {
                TreeNode node = new TreeNode(row["name"].ToString(), 3, 3);
                treeViewExplorer.Nodes[0].Nodes[1].Nodes.Add(node);
            }
        }

        public void PopulateTreeViewExplorer(string connectionString)
        {
            userDatabasesTableAdapter.Connection.ConnectionString = connectionString;
            backup_devicesTableAdapter.Connection.ConnectionString = connectionString;
            //userDatabasesTableAdapter.Fill(mainForm.appData.UserDatabases);

            foreach (DataRow row in userDatabasesTableAdapter.GetData().Rows)
            {
                TreeNode node = new TreeNode(row["name"].ToString(), 2, 2);
                treeViewExplorer.Nodes[0].Nodes[0].Nodes.Add(node);
            }

            foreach (DataRow row in backup_devicesTableAdapter.GetData().Rows)
            {
                TreeNode node = new TreeNode(row["name"].ToString(), 3, 3);
                treeViewExplorer.Nodes[0].Nodes[1].Nodes.Add(node);
            }
        }
    }
}
