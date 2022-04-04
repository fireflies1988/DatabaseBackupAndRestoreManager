using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseBackupManager
{
    public partial class BackupForm : Form
    {
        private MainForm mainForm;
        public BackupForm(MainForm mainForm)
        {
            Utils.ChangeLanguage(Utils.ReadResource("lang"));

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
            toolStripStatusLabelBackingUp.Text += textBoxName.Text;
            ActiveControl = textBoxDescription;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            panelBackupContent.Enabled = false;
            statusStripProcessStats.Visible = true;
            statusStripProcessStats.Update();
            try
            {
                SqlConnection connection = SqlServer.GetConnection();
                connection.InfoMessage += OnInfoMessageGenerated;
                connection.FireInfoMessageEventOnUserErrors = true;
                if (radioButtonOverwrite.Checked)
                {
                    SqlServer.ExecuteNonQuery(connection,
                        string.Format(QueryString.BACKUP_WITH_INIT, textBoxDatabase.Text, textBoxBackupDevice.Text, textBoxName.Text, textBoxDescription.Text));
                }
                else
                {
                    SqlServer.ExecuteNonQuery(connection,
                        string.Format(QueryString.BACKUP, textBoxDatabase.Text, textBoxBackupDevice.Text, textBoxName.Text, textBoxDescription.Text));
                }
                MessageBox.Show(this, GlobalStrings.BackUpDatabaseHeadText + textBoxDatabase.Text + GlobalStrings.BackUpDatabaseTailText,
                    GlobalStrings.BackUpDatabaseCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                mainForm.RefreshBackupHistoryTable(textBoxBackupDevice.Text, textBoxDatabase.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, GlobalStrings.BackUpDatabaseCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                panelBackupContent.Enabled = true;
            }
        }

        private void OnInfoMessageGenerated(object sender, SqlInfoMessageEventArgs args)
        {
            if (int.TryParse(args.Message.Substring(0, args.Message.IndexOf(' ')), out int percent))
            {
                toolStripStatusLabelPercent.Text = percent + "%";
                toolStripProgressBarBackingUp.Value = percent;
                statusStripProcessStats.Update();
            }
        }
    }
}
