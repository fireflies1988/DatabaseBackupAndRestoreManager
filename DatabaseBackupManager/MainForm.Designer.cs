
namespace DatabaseBackupManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBackupDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiengVietToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxDatabases = new System.Windows.Forms.GroupBox();
            this.listBoxDatabases = new System.Windows.Forms.ListBox();
            this.userDatabasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new DatabaseBackupManager.AppData();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelServerNameAndLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxBackupHistory = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDatabasesTableAdapter = new DatabaseBackupManager.AppDataTableAdapters.userDatabasesTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.groupBoxDatabases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDatabasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxBackupHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.backupToolStripMenuItem,
            this.restoreToolStripMenuItem,
            this.newBackupDeviceToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("connectToolStripMenuItem.Image")));
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(108, 28);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Enabled = false;
            this.disconnectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("disconnectToolStripMenuItem.Image")));
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(128, 28);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Enabled = false;
            this.refreshToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("refreshToolStripMenuItem.Image")));
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(100, 28);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Enabled = false;
            this.backupToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("backupToolStripMenuItem.Image")));
            this.backupToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(103, 28);
            this.backupToolStripMenuItem.Text = "Backup";
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Enabled = false;
            this.restoreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("restoreToolStripMenuItem.Image")));
            this.restoreToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(105, 28);
            this.restoreToolStripMenuItem.Text = "Restore";
            // 
            // newBackupDeviceToolStripMenuItem
            // 
            this.newBackupDeviceToolStripMenuItem.Enabled = false;
            this.newBackupDeviceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newBackupDeviceToolStripMenuItem.Image")));
            this.newBackupDeviceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newBackupDeviceToolStripMenuItem.Name = "newBackupDeviceToolStripMenuItem";
            this.newBackupDeviceToolStripMenuItem.Size = new System.Drawing.Size(197, 28);
            this.newBackupDeviceToolStripMenuItem.Text = "New Backup Device";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.tiengVietToolStripMenuItem});
            this.languageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("languageToolStripMenuItem.Image")));
            this.languageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(102, 28);
            this.languageToolStripMenuItem.Text = "English";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Checked = true;
            this.englishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(171, 28);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // tiengVietToolStripMenuItem
            // 
            this.tiengVietToolStripMenuItem.Name = "tiengVietToolStripMenuItem";
            this.tiengVietToolStripMenuItem.Size = new System.Drawing.Size(171, 28);
            this.tiengVietToolStripMenuItem.Text = "Tiếng Việt";
            this.tiengVietToolStripMenuItem.Click += new System.EventHandler(this.tiengVietToolStripMenuItem_Click);
            // 
            // groupBoxDatabases
            // 
            this.groupBoxDatabases.Controls.Add(this.listBoxDatabases);
            this.groupBoxDatabases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDatabases.Enabled = false;
            this.groupBoxDatabases.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatabases.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDatabases.Name = "groupBoxDatabases";
            this.groupBoxDatabases.Size = new System.Drawing.Size(228, 495);
            this.groupBoxDatabases.TabIndex = 1;
            this.groupBoxDatabases.TabStop = false;
            this.groupBoxDatabases.Text = "Databases";
            // 
            // listBoxDatabases
            // 
            this.listBoxDatabases.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxDatabases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxDatabases.DataSource = this.userDatabasesBindingSource;
            this.listBoxDatabases.DisplayMember = "name";
            this.listBoxDatabases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxDatabases.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDatabases.FormattingEnabled = true;
            this.listBoxDatabases.ItemHeight = 20;
            this.listBoxDatabases.Location = new System.Drawing.Point(3, 23);
            this.listBoxDatabases.Name = "listBoxDatabases";
            this.listBoxDatabases.Size = new System.Drawing.Size(222, 469);
            this.listBoxDatabases.TabIndex = 0;
            // 
            // userDatabasesBindingSource
            // 
            this.userDatabasesBindingSource.DataMember = "UserDatabases";
            this.userDatabasesBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelServerNameAndLogin});
            this.statusStrip1.Location = new System.Drawing.Point(0, 527);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(924, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelServerNameAndLogin
            // 
            this.toolStripStatusLabelServerNameAndLogin.Name = "toolStripStatusLabelServerNameAndLogin";
            this.toolStripStatusLabelServerNameAndLogin.Size = new System.Drawing.Size(0, 16);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxDatabases);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 495);
            this.panel1.TabIndex = 3;
            // 
            // groupBoxBackupHistory
            // 
            this.groupBoxBackupHistory.Controls.Add(this.dataGridView1);
            this.groupBoxBackupHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBackupHistory.Enabled = false;
            this.groupBoxBackupHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBackupHistory.Location = new System.Drawing.Point(228, 32);
            this.groupBoxBackupHistory.Name = "groupBoxBackupHistory";
            this.groupBoxBackupHistory.Size = new System.Drawing.Size(696, 495);
            this.groupBoxBackupHistory.TabIndex = 4;
            this.groupBoxBackupHistory.TabStop = false;
            this.groupBoxBackupHistory.Text = "Backup History";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(690, 235);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Position";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Backup Finish Date";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "User Name";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Note";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // userDatabasesTableAdapter
            // 
            this.userDatabasesTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(924, 549);
            this.Controls.Add(this.groupBoxBackupHistory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Backup & Restore Manager for Microsoft SQL Server";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxDatabases.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDatabasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBoxBackupHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBackupDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiengVietToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.GroupBox groupBoxDatabases;
        public System.Windows.Forms.GroupBox groupBoxBackupHistory;
        public System.Windows.Forms.ListBox listBoxDatabases;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelServerNameAndLogin;
        public System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.BindingSource userDatabasesBindingSource;
        public AppDataTableAdapters.userDatabasesTableAdapter userDatabasesTableAdapter;
        public AppData appData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}