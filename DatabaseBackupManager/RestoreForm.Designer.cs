
namespace DatabaseBackupManager
{
    partial class RestoreForm
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
            this.panelRestoreContent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonTimeOption = new System.Windows.Forms.RadioButton();
            this.radioButtonChooseBackupSet = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.panelDateAndTime = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBackupDevice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStripProcessStats = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelRestoring = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarRestoring = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabelPercent = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelRestoreContent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDateAndTime.SuspendLayout();
            this.statusStripProcessStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRestoreContent
            // 
            this.panelRestoreContent.Controls.Add(this.panel1);
            this.panelRestoreContent.Controls.Add(this.buttonCancel);
            this.panelRestoreContent.Controls.Add(this.buttonOK);
            this.panelRestoreContent.Controls.Add(this.panelDateAndTime);
            this.panelRestoreContent.Controls.Add(this.label7);
            this.panelRestoreContent.Controls.Add(this.label4);
            this.panelRestoreContent.Controls.Add(this.textBoxBackupDevice);
            this.panelRestoreContent.Controls.Add(this.label3);
            this.panelRestoreContent.Controls.Add(this.textBoxDatabase);
            this.panelRestoreContent.Controls.Add(this.label1);
            this.panelRestoreContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRestoreContent.Location = new System.Drawing.Point(0, 0);
            this.panelRestoreContent.Name = "panelRestoreContent";
            this.panelRestoreContent.Size = new System.Drawing.Size(665, 335);
            this.panelRestoreContent.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonTimeOption);
            this.panel1.Controls.Add(this.radioButtonChooseBackupSet);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBoxPosition);
            this.panel1.Location = new System.Drawing.Point(38, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 60);
            this.panel1.TabIndex = 43;
            // 
            // radioButtonTimeOption
            // 
            this.radioButtonTimeOption.AutoSize = true;
            this.radioButtonTimeOption.Location = new System.Drawing.Point(3, 34);
            this.radioButtonTimeOption.Name = "radioButtonTimeOption";
            this.radioButtonTimeOption.Size = new System.Drawing.Size(340, 21);
            this.radioButtonTimeOption.TabIndex = 47;
            this.radioButtonTimeOption.Text = "Specific date and time after the last backup taken";
            this.radioButtonTimeOption.UseVisualStyleBackColor = true;
            this.radioButtonTimeOption.CheckedChanged += new System.EventHandler(this.radioButtonTimeOption_CheckedChanged);
            // 
            // radioButtonChooseBackupSet
            // 
            this.radioButtonChooseBackupSet.AutoSize = true;
            this.radioButtonChooseBackupSet.Checked = true;
            this.radioButtonChooseBackupSet.Location = new System.Drawing.Point(3, 6);
            this.radioButtonChooseBackupSet.Name = "radioButtonChooseBackupSet";
            this.radioButtonChooseBackupSet.Size = new System.Drawing.Size(54, 21);
            this.radioButtonChooseBackupSet.TabIndex = 46;
            this.radioButtonChooseBackupSet.TabStop = true;
            this.radioButtonChooseBackupSet.Text = "The";
            this.radioButtonChooseBackupSet.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "th backup set on the backup device";
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.DisplayMember = "name";
            this.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(61, 4);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(74, 24);
            this.comboBoxPosition.TabIndex = 44;
            this.comboBoxPosition.ValueMember = "name";
            this.comboBoxPosition.TextChanged += new System.EventHandler(this.comboBoxPosition_TextChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(497, 269);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(143, 30);
            this.buttonCancel.TabIndex = 42;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(348, 269);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(143, 30);
            this.buttonOK.TabIndex = 41;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // panelDateAndTime
            // 
            this.panelDateAndTime.Controls.Add(this.label8);
            this.panelDateAndTime.Controls.Add(this.dateTimePickerTime);
            this.panelDateAndTime.Controls.Add(this.label6);
            this.panelDateAndTime.Controls.Add(this.dateTimePickerDate);
            this.panelDateAndTime.Controls.Add(this.label2);
            this.panelDateAndTime.Enabled = false;
            this.panelDateAndTime.Location = new System.Drawing.Point(38, 162);
            this.panelDateAndTime.Name = "panelDateAndTime";
            this.panelDateAndTime.Size = new System.Drawing.Size(602, 92);
            this.panelDateAndTime.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(19, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(583, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "The date and time here must be at or after the time of the last backup taken.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(175, 28);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.ShowUpDown = true;
            this.dateTimePickerTime.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTime.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Time:";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(175, 0);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date:";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(97, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(543, 2);
            this.label7.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Restore to";
            // 
            // textBoxBackupDevice
            // 
            this.textBoxBackupDevice.Location = new System.Drawing.Point(191, 43);
            this.textBoxBackupDevice.Name = "textBoxBackupDevice";
            this.textBoxBackupDevice.ReadOnly = true;
            this.textBoxBackupDevice.Size = new System.Drawing.Size(449, 22);
            this.textBoxBackupDevice.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Backup device:";
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Location = new System.Drawing.Point(191, 15);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.ReadOnly = true;
            this.textBoxDatabase.Size = new System.Drawing.Size(449, 22);
            this.textBoxDatabase.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Database:";
            // 
            // statusStripProcessStats
            // 
            this.statusStripProcessStats.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripProcessStats.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelRestoring,
            this.toolStripProgressBarRestoring,
            this.toolStripStatusLabelPercent});
            this.statusStripProcessStats.Location = new System.Drawing.Point(0, 309);
            this.statusStripProcessStats.Name = "statusStripProcessStats";
            this.statusStripProcessStats.Size = new System.Drawing.Size(665, 26);
            this.statusStripProcessStats.SizingGrip = false;
            this.statusStripProcessStats.TabIndex = 21;
            this.statusStripProcessStats.Text = "statusStrip1";
            this.statusStripProcessStats.Visible = false;
            // 
            // toolStripStatusLabelRestoring
            // 
            this.toolStripStatusLabelRestoring.Name = "toolStripStatusLabelRestoring";
            this.toolStripStatusLabelRestoring.Size = new System.Drawing.Size(419, 20);
            this.toolStripStatusLabelRestoring.Spring = true;
            this.toolStripStatusLabelRestoring.Text = "Restoring: ";
            this.toolStripStatusLabelRestoring.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBarRestoring
            // 
            this.toolStripProgressBarRestoring.Name = "toolStripProgressBarRestoring";
            this.toolStripProgressBarRestoring.Size = new System.Drawing.Size(200, 18);
            // 
            // toolStripStatusLabelPercent
            // 
            this.toolStripStatusLabelPercent.AutoSize = false;
            this.toolStripStatusLabelPercent.Name = "toolStripStatusLabelPercent";
            this.toolStripStatusLabelPercent.Size = new System.Drawing.Size(29, 20);
            this.toolStripStatusLabelPercent.Text = "0%";
            // 
            // RestoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 335);
            this.Controls.Add(this.statusStripProcessStats);
            this.Controls.Add(this.panelRestoreContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RestoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Restore Database - ";
            this.Load += new System.EventHandler(this.RestoreForm_Load);
            this.panelRestoreContent.ResumeLayout(false);
            this.panelRestoreContent.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDateAndTime.ResumeLayout(false);
            this.panelDateAndTime.PerformLayout();
            this.statusStripProcessStats.ResumeLayout(false);
            this.statusStripProcessStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelRestoreContent;
        private System.Windows.Forms.StatusStrip statusStripProcessStats;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRestoring;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarRestoring;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPercent;
        private System.Windows.Forms.TextBox textBoxBackupDevice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelDateAndTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonTimeOption;
        private System.Windows.Forms.RadioButton radioButtonChooseBackupSet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxPosition;
    }
}