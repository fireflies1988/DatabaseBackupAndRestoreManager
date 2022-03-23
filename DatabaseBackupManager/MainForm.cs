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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
            changeLanguage(sender);
        }

        private void tiengVietToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeLanguage(sender);
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConnectToServerForm(this).ShowDialog();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userDatabasesTableAdapter.Fill(appData.UserDatabases);
        }
    }
}
