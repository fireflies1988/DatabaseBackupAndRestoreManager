
namespace DatabaseBackupManager
{
    partial class BackupForm
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
            this.statusStripProcessStats = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelBackingUp = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarBackingUp = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabelPercent = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelBackupContent = new System.Windows.Forms.Panel();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonOverwrite = new System.Windows.Forms.RadioButton();
            this.radioButtonAppend = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBackupDevice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStripProcessStats.SuspendLayout();
            this.panelBackupContent.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripProcessStats
            // 
            this.statusStripProcessStats.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripProcessStats.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelBackingUp,
            this.toolStripProgressBarBackingUp,
            this.toolStripStatusLabelPercent});
            this.statusStripProcessStats.Location = new System.Drawing.Point(0, 300);
            this.statusStripProcessStats.Name = "statusStripProcessStats";
            this.statusStripProcessStats.Size = new System.Drawing.Size(662, 26);
            this.statusStripProcessStats.SizingGrip = false;
            this.statusStripProcessStats.TabIndex = 20;
            this.statusStripProcessStats.Text = "statusStrip1";
            this.statusStripProcessStats.Visible = false;
            // 
            // toolStripStatusLabelBackingUp
            // 
            this.toolStripStatusLabelBackingUp.Name = "toolStripStatusLabelBackingUp";
            this.toolStripStatusLabelBackingUp.Size = new System.Drawing.Size(377, 20);
            this.toolStripStatusLabelBackingUp.Spring = true;
            this.toolStripStatusLabelBackingUp.Text = "Backing up: ";
            this.toolStripStatusLabelBackingUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBarBackingUp
            // 
            this.toolStripProgressBarBackingUp.Name = "toolStripProgressBarBackingUp";
            this.toolStripProgressBarBackingUp.Size = new System.Drawing.Size(200, 18);
            // 
            // toolStripStatusLabelPercent
            // 
            this.toolStripStatusLabelPercent.AutoSize = false;
            this.toolStripStatusLabelPercent.Name = "toolStripStatusLabelPercent";
            this.toolStripStatusLabelPercent.Size = new System.Drawing.Size(29, 20);
            this.toolStripStatusLabelPercent.Text = "0%";
            // 
            // panelBackupContent
            // 
            this.panelBackupContent.Controls.Add(this.textBoxDescription);
            this.panelBackupContent.Controls.Add(this.label6);
            this.panelBackupContent.Controls.Add(this.buttonCancel);
            this.panelBackupContent.Controls.Add(this.buttonOK);
            this.panelBackupContent.Controls.Add(this.textBoxName);
            this.panelBackupContent.Controls.Add(this.label5);
            this.panelBackupContent.Controls.Add(this.panel2);
            this.panelBackupContent.Controls.Add(this.label7);
            this.panelBackupContent.Controls.Add(this.label4);
            this.panelBackupContent.Controls.Add(this.textBoxBackupDevice);
            this.panelBackupContent.Controls.Add(this.label3);
            this.panelBackupContent.Controls.Add(this.textBox2);
            this.panelBackupContent.Controls.Add(this.label2);
            this.panelBackupContent.Controls.Add(this.textBoxDatabase);
            this.panelBackupContent.Controls.Add(this.label1);
            this.panelBackupContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackupContent.Location = new System.Drawing.Point(0, 0);
            this.panelBackupContent.Name = "panelBackupContent";
            this.panelBackupContent.Size = new System.Drawing.Size(662, 326);
            this.panelBackupContent.TabIndex = 21;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(193, 219);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(449, 22);
            this.textBoxDescription.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Description:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(499, 259);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(143, 30);
            this.buttonCancel.TabIndex = 32;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(350, 259);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(143, 30);
            this.buttonOK.TabIndex = 31;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(193, 191);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(449, 22);
            this.textBoxName.TabIndex = 30;
            this.textBoxName.Text = "-Full Database Backup";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Name:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonOverwrite);
            this.panel2.Controls.Add(this.radioButtonAppend);
            this.panel2.Location = new System.Drawing.Point(23, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(619, 59);
            this.panel2.TabIndex = 28;
            // 
            // radioButtonOverwrite
            // 
            this.radioButtonOverwrite.AutoSize = true;
            this.radioButtonOverwrite.Location = new System.Drawing.Point(3, 30);
            this.radioButtonOverwrite.Name = "radioButtonOverwrite";
            this.radioButtonOverwrite.Size = new System.Drawing.Size(238, 21);
            this.radioButtonOverwrite.TabIndex = 1;
            this.radioButtonOverwrite.Text = "Overwrite all existing backup sets";
            this.radioButtonOverwrite.UseVisualStyleBackColor = true;
            // 
            // radioButtonAppend
            // 
            this.radioButtonAppend.AutoSize = true;
            this.radioButtonAppend.Checked = true;
            this.radioButtonAppend.Location = new System.Drawing.Point(3, 3);
            this.radioButtonAppend.Name = "radioButtonAppend";
            this.radioButtonAppend.Size = new System.Drawing.Size(242, 21);
            this.radioButtonAppend.TabIndex = 0;
            this.radioButtonAppend.TabStop = true;
            this.radioButtonAppend.Text = "Append to the existing backup set";
            this.radioButtonAppend.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(134, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(508, 2);
            this.label7.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Backup Options";
            // 
            // textBoxBackupDevice
            // 
            this.textBoxBackupDevice.Location = new System.Drawing.Point(193, 67);
            this.textBoxBackupDevice.Name = "textBoxBackupDevice";
            this.textBoxBackupDevice.ReadOnly = true;
            this.textBoxBackupDevice.Size = new System.Drawing.Size(449, 22);
            this.textBoxBackupDevice.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Backup device:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(193, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(449, 22);
            this.textBox2.TabIndex = 23;
            this.textBox2.Text = "Full";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Backup type:";
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Location = new System.Drawing.Point(193, 11);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.ReadOnly = true;
            this.textBoxDatabase.Size = new System.Drawing.Size(449, 22);
            this.textBoxDatabase.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Database:";
            // 
            // BackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 326);
            this.Controls.Add(this.panelBackupContent);
            this.Controls.Add(this.statusStripProcessStats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Back Up Database - ";
            this.Load += new System.EventHandler(this.BackupForm_Load);
            this.statusStripProcessStats.ResumeLayout(false);
            this.statusStripProcessStats.PerformLayout();
            this.panelBackupContent.ResumeLayout(false);
            this.panelBackupContent.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStripProcessStats;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelBackingUp;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarBackingUp;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPercent;
        private System.Windows.Forms.Panel panelBackupContent;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonOverwrite;
        private System.Windows.Forms.RadioButton radioButtonAppend;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBackupDevice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.Label label1;
    }
}