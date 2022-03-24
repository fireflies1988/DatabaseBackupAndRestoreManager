
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDatabasesTableAdapter = new DatabaseBackupManager.AppDataTableAdapters.userDatabasesTableAdapter();
            this.backup_devicesTableAdapter = new DatabaseBackupManager.AppDataTableAdapters.backup_devicesTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.groupBoxExplorer.SuspendLayout();
            this.groupBoxBackupHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
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
            this.treeViewExplorer.BackColor = System.Drawing.SystemColors.Control;
            this.treeViewExplorer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.treeViewExplorer, "treeViewExplorer");
            this.treeViewExplorer.ImageList = this.imageListExplorer;
            this.treeViewExplorer.Name = "treeViewExplorer";
            this.treeViewExplorer.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            ((System.Windows.Forms.TreeNode)(resources.GetObject("treeViewExplorer.Nodes")))});
            // 
            // groupBoxBackupHistory
            // 
            resources.ApplyResources(this.groupBoxBackupHistory, "groupBoxBackupHistory");
            this.groupBoxBackupHistory.Controls.Add(this.dataGridView1);
            this.groupBoxBackupHistory.Name = "groupBoxBackupHistory";
            this.groupBoxBackupHistory.TabStop = false;
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
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            // 
            // Column1
            // 
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // userDatabasesTableAdapter
            // 
            this.userDatabasesTableAdapter.ClearBeforeFill = true;
            // 
            // backup_devicesTableAdapter
            // 
            this.backup_devicesTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
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
        public System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ImageList imageListExplorer;
        public System.Windows.Forms.GroupBox groupBoxBackupHistory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        public System.Windows.Forms.TreeView treeViewExplorer;
        public System.Windows.Forms.GroupBox groupBoxExplorer;
        public AppDataTableAdapters.userDatabasesTableAdapter userDatabasesTableAdapter;
        public AppDataTableAdapters.backup_devicesTableAdapter backup_devicesTableAdapter;
    }
}