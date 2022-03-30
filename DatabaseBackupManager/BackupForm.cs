using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseBackupManager
{
    public partial class BackupForm : Form
    {
        private MainForm mainForm;
        public BackupForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BackupForm_Load(object sender, EventArgs e)
        {
            string databaseName = mainForm.treeViewExplorer.SelectedNode.Text;
            Text += databaseName;
            textBoxDatabase.Text = databaseName;
            textBoxBackupDevice.Text = "bd_" + databaseName;
            textBoxName.Text = databaseName + textBoxName.Text;
            ActiveControl = textBoxDescription;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonOverwrite.Checked)
                {
                    SqlServer.ExecuteNonQuery(SqlServer.GetConnection(),
                        string.Format(QueryString.BACKUP_WITH_INIT, textBoxDatabase.Text, textBoxBackupDevice.Text, textBoxName.Text, textBoxDescription.Text));
                }
                else
                {
                    SqlServer.ExecuteNonQuery(SqlServer.GetConnection(),
                        string.Format(QueryString.BACKUP, textBoxDatabase.Text, textBoxBackupDevice.Text, textBoxName.Text, textBoxDescription.Text));
                }
                MessageBox.Show(this, "The backup of database '" + textBoxDatabase.Text + "' completed successfully.", 
                    "Back Up Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                mainForm.RefreshBackupHistoryTable(textBoxBackupDevice.Text, textBoxDatabase.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Back Up Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
