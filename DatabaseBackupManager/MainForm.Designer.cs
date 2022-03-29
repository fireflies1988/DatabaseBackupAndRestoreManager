
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.imageListExplorer = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxExplorer = new System.Windows.Forms.GroupBox();
            this.treeViewExplorer = new System.Windows.Forms.TreeView();
            this.groupBoxBackupHistory = new System.Windows.Forms.GroupBox();
            this.dataGridViewBackupHistory = new System.Windows.Forms.DataGridView();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backupstartdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backupfinishdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backupHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new DatabaseBackupManager.AppData();
            this.userDatabasesTableAdapter = new DatabaseBackupManager.AppDataTableAdapters.userDatabasesTableAdapter();
            this.backup_devicesTableAdapter = new DatabaseBackupManager.AppDataTableAdapters.backup_devicesTableAdapter();
            this.backupHistoryTableAdapter = new DatabaseBackupManager.AppDataTableAdapters.BackupHistoryTableAdapter();
            this.backupDevicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBoxExplorer.SuspendLayout();
            this.groupBoxBackupHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBackupHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupDevicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
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
            this.menuStrip1.Name = "menuStrip1";
            // 
            // connectToolStripMenuItem
            // 
            resources.ApplyResources(this.connectToolStripMenuItem, "connectToolStripMenuItem");
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            resources.ApplyResources(this.disconnectToolStripMenuItem, "disconnectToolStripMenuItem");
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            resources.ApplyResources(this.refreshToolStripMenuItem, "refreshToolStripMenuItem");
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            resources.ApplyResources(this.backupToolStripMenuItem, "backupToolStripMenuItem");
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            // 
            // restoreToolStripMenuItem
            // 
            resources.ApplyResources(this.restoreToolStripMenuItem, "restoreToolStripMenuItem");
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            // 
            // newBackupDeviceToolStripMenuItem
            // 
            resources.ApplyResources(this.newBackupDeviceToolStripMenuItem, "newBackupDeviceToolStripMenuItem");
            this.newBackupDeviceToolStripMenuItem.Name = "newBackupDeviceToolStripMenuItem";
            this.newBackupDeviceToolStripMenuItem.Click += new System.EventHandler(this.newBackupDeviceToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.tiengVietToolStripMenuItem});
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Checked = true;
            this.englishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // tiengVietToolStripMenuItem
            // 
            this.tiengVietToolStripMenuItem.Name = "tiengVietToolStripMenuItem";
            resources.ApplyResources(this.tiengVietToolStripMenuItem, "tiengVietToolStripMenuItem");
            this.tiengVietToolStripMenuItem.Click += new System.EventHandler(this.tiengVietToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // imageListExplorer
            // 
            this.imageListExplorer.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListExplorer.ImageStream")));
            this.imageListExplorer.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListExplorer.Images.SetKeyName(0, "icons8-database-view-16.png");
            this.imageListExplorer.Images.SetKeyName(1, "icons8-folder-16.png");
            this.imageListExplorer.Images.SetKeyName(2, "icons8-database-16.png");
            this.imageListExplorer.Images.SetKeyName(3, "icons8-hdmi-cable-16.png");
            // 
            // groupBoxExplorer
            // 
            this.groupBoxExplorer.Controls.Add(this.treeViewExplorer);
            resources.ApplyResources(this.groupBoxExplorer, "groupBoxExplorer");
            this.groupBoxExplorer.Name = "groupBoxExplorer";
            this.groupBoxExplorer.TabStop = false;
            // 
            // treeViewExplorer
            // 
            this.treeViewExplorer.BackColor = System.Drawing.SystemColors.Window;
            this.treeViewExplorer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.treeViewExplorer, "treeViewExplorer");
            this.treeViewExplorer.HideSelection = false;
            this.treeViewExplorer.ImageList = this.imageListExplorer;
            this.treeViewExplorer.Name = "treeViewExplorer";
            this.treeViewExplorer.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            ((System.Windows.Forms.TreeNode)(resources.GetObject("treeViewExplorer.Nodes")))});
            this.treeViewExplorer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewExplorer_AfterSelect);
            // 
            // groupBoxBackupHistory
            // 
            resources.ApplyResources(this.groupBoxBackupHistory, "groupBoxBackupHistory");
            this.groupBoxBackupHistory.Controls.Add(this.dataGridViewBackupHistory);
            this.groupBoxBackupHistory.Name = "groupBoxBackupHistory";
            this.groupBoxBackupHistory.TabStop = false;
            // 
            // dataGridViewBackupHistory
            // 
            this.dataGridViewBackupHistory.AllowUserToAddRows = false;
            this.dataGridViewBackupHistory.AllowUserToDeleteRows = false;
            this.dataGridViewBackupHistory.AllowUserToOrderColumns = true;
            this.dataGridViewBackupHistory.AutoGenerateColumns = false;
            this.dataGridViewBackupHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBackupHistory.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewBackupHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBackupHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBackupHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.positionDataGridViewTextBoxColumn,
            this.backupstartdateDataGridViewTextBoxColumn,
            this.backupfinishdateDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridViewBackupHistory.DataSource = this.backupHistoryBindingSource;
            resources.ApplyResources(this.dataGridViewBackupHistory, "dataGridViewBackupHistory");
            this.dataGridViewBackupHistory.Name = "dataGridViewBackupHistory";
            this.dataGridViewBackupHistory.ReadOnly = true;
            this.dataGridViewBackupHistory.RowTemplate.Height = 24;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            resources.ApplyResources(this.positionDataGridViewTextBoxColumn, "positionDataGridViewTextBoxColumn");
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // backupstartdateDataGridViewTextBoxColumn
            // 
            this.backupstartdateDataGridViewTextBoxColumn.DataPropertyName = "backup_start_date";
            resources.ApplyResources(this.backupstartdateDataGridViewTextBoxColumn, "backupstartdateDataGridViewTextBoxColumn");
            this.backupstartdateDataGridViewTextBoxColumn.Name = "backupstartdateDataGridViewTextBoxColumn";
            this.backupstartdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // backupfinishdateDataGridViewTextBoxColumn
            // 
            this.backupfinishdateDataGridViewTextBoxColumn.DataPropertyName = "backup_finish_date";
            resources.ApplyResources(this.backupfinishdateDataGridViewTextBoxColumn, "backupfinishdateDataGridViewTextBoxColumn");
            this.backupfinishdateDataGridViewTextBoxColumn.Name = "backupfinishdateDataGridViewTextBoxColumn";
            this.backupfinishdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "user_name";
            resources.ApplyResources(this.usernameDataGridViewTextBoxColumn, "usernameDataGridViewTextBoxColumn");
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            resources.ApplyResources(this.descriptionDataGridViewTextBoxColumn, "descriptionDataGridViewTextBoxColumn");
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // backupHistoryBindingSource
            // 
            this.backupHistoryBindingSource.DataMember = "BackupHistory";
            this.backupHistoryBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userDatabasesTableAdapter
            // 
            this.userDatabasesTableAdapter.ClearBeforeFill = true;
            // 
            // backup_devicesTableAdapter
            // 
            this.backup_devicesTableAdapter.ClearBeforeFill = true;
            // 
            // backupHistoryTableAdapter
            // 
            this.backupHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // backupDevicesBindingSource
            // 
            this.backupDevicesBindingSource.DataMember = "backup_devices";
            this.backupDevicesBindingSource.DataSource = this.appData;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.groupBoxBackupHistory);
            this.Controls.Add(this.groupBoxExplorer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxExplorer.ResumeLayout(false);
            this.groupBoxBackupHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBackupHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupDevicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiengVietToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ImageList imageListExplorer;
        public System.Windows.Forms.GroupBox groupBoxBackupHistory;
        private System.Windows.Forms.DataGridView dataGridViewBackupHistory;
        public System.Windows.Forms.TreeView treeViewExplorer;
        public System.Windows.Forms.GroupBox groupBoxExplorer;
        public AppDataTableAdapters.userDatabasesTableAdapter userDatabasesTableAdapter;
        public AppDataTableAdapters.backup_devicesTableAdapter backup_devicesTableAdapter;
        private System.Windows.Forms.BindingSource backupHistoryBindingSource;
        private AppData appData;
        private AppDataTableAdapters.BackupHistoryTableAdapter backupHistoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backupstartdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backupfinishdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource backupDevicesBindingSource;
        public System.Windows.Forms.ToolStripMenuItem newBackupDeviceToolStripMenuItem;
    }
}