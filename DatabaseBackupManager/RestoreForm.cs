using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DatabaseBackupManager
{
    public partial class RestoreForm : Form
    {
        private MainForm mainForm;
        public RestoreForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void RestoreForm_Load(object sender, System.EventArgs e)
        {
            comboBoxPosition.DataSource = mainForm.backupHistoryBindingSource;
            comboBoxPosition.DisplayMember = "position";
            comboBoxPosition.ValueMember = "name";

            string databaseName = mainForm.treeViewExplorer.SelectedNode.Text;
            Text += databaseName;
            textBoxDatabase.Text = databaseName;
            textBoxBackupDevice.Text = "bd_" + databaseName;
            ActiveControl = buttonOK;
        }

        private void buttonOK_Click(object sender, System.EventArgs e)
        {
            panelRestoreContent.Enabled = false;
            statusStripProcessStats.Visible = true;
            statusStripProcessStats.Update();
            try
            {
                SqlConnection connection = SqlServer.GetConnection();
                connection.InfoMessage += OnInfoMessageGenerated;
                connection.FireInfoMessageEventOnUserErrors = true;
                if (radioButtonTimeOption.Checked)
                {
                    string dateAndTime = dateTimePickerDate.Value.ToString("MM/dd/yyyy") + " " + dateTimePickerTime.Value.ToString("hh:mm:ss tt");
                    int maxPosition = mainForm.dataGridViewBackupHistory.Rows.Cast<DataGridViewRow>()
                        .Max(r => Convert.ToInt32(r.Cells["position"].Value));
                    
                    SqlServer.ExecuteNonQuery(connection,
                        string.Format(QueryString.RESTORE_TO_SPECIFIC_TIME, textBoxDatabase.Text, 
                        textBoxBackupDevice.Text, maxPosition, dateAndTime));
                }
                else
                {
                    SqlServer.ExecuteNonQuery(connection,
                        string.Format(QueryString.RESTORE, textBoxDatabase.Text, textBoxBackupDevice.Text, comboBoxPosition.Text));
                }
                MessageBox.Show(this, GlobalStrings.RestoreDatabaseHeadText + textBoxDatabase.Text + GlobalStrings.RestoreDatabaseTailText,
                    GlobalStrings.RestoreDatabaseCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, GlobalStrings.RestoreDatabaseCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                panelRestoreContent.Enabled = true;
            }
        }

        private void OnInfoMessageGenerated(object sender, SqlInfoMessageEventArgs args)
        {
            if (int.TryParse(args.Message.Substring(0, args.Message.IndexOf(' ')), out int percent))
            {
                toolStripStatusLabelPercent.Text = percent + "%";
                toolStripProgressBarRestoring.Value = percent;
                statusStripProcessStats.Update();
            }
        }

        private void comboBoxPosition_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxPosition.SelectedValue != null)
            {
                toolStripStatusLabelRestoring.Text = GlobalStrings.RestoringText + comboBoxPosition.SelectedValue.ToString();
            }
        }

        private void radioButtonTimeOption_CheckedChanged(object sender, EventArgs e)
        {
            panelDateAndTime.Enabled = radioButtonTimeOption.Checked;
        }
    }
}
