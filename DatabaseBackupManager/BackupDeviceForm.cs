using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseBackupManager
{
    public partial class BackupDeviceForm : Form
    {
        private MainForm mainForm;
        public BackupDeviceForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                SqlServer.ExecuteNonQuery(SqlServer.GetConnection(),
                    string.Format(QueryString.NEW_BACKUP_DEVICE, textBoxDeviceName.Text, textBoxLocation.Text));

                string selectedNode = mainForm.treeViewExplorer.SelectedNode.Text;
                mainForm.refreshToolStripMenuItem.PerformClick();
                TreeNode[] treeNodes = mainForm.treeViewExplorer.Nodes[0].Nodes[0].Nodes.Find(selectedNode, false);
                mainForm.treeViewExplorer.SelectedNode = treeNodes[0];
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Backup Device", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackupDeviceForm_Load(object sender, EventArgs e)
        {
            ActiveControl = buttonOK;
            textBoxDeviceName.Text = "bd_" + mainForm.treeViewExplorer.SelectedNode.Text;
            
            try
            {
                using (SqlConnection con = SqlServer.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(QueryString.DEFAULT_BACKUP_LOCATION, con))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            dr.Read();
                            folderBrowserDialog.SelectedPath = dr.GetString(0);
                            textBoxLocation.Text = folderBrowserDialog.SelectedPath + "\\" + textBoxDeviceName.Text + ".bak";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Backup Device", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxLocation.Text = folderBrowserDialog.SelectedPath + "\\" + textBoxDeviceName.Text + ".bak";
            }
        }
    }
}
