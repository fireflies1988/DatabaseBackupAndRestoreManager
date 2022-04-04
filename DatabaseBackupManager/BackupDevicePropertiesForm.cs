using System;
using System.Windows.Forms;

namespace DatabaseBackupManager
{
    public partial class BackupDevicePropertiesForm : Form
    {
        private MainForm mainForm;
        public BackupDevicePropertiesForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void BackupDevicePropertiesForm_Load(object sender, EventArgs e)
        {
            ActiveControl = buttonOK;
            textBoxDeviceName.Text = mainForm.treeViewExplorer.SelectedNode.Text;

            try
            {
                textBoxLocation.Text = 
                    SqlServer.ReadFirstCell(string.Format(QueryString.BACKUP_DEVICE_LOCATION, textBoxDeviceName.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Backup Device", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
