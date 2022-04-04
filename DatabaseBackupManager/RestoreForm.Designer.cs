
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestoreForm));
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
            resources.ApplyResources(this.panelRestoreContent, "panelRestoreContent");
            this.panelRestoreContent.Name = "panelRestoreContent";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonTimeOption);
            this.panel1.Controls.Add(this.radioButtonChooseBackupSet);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBoxPosition);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // radioButtonTimeOption
            // 
            resources.ApplyResources(this.radioButtonTimeOption, "radioButtonTimeOption");
            this.radioButtonTimeOption.Name = "radioButtonTimeOption";
            this.radioButtonTimeOption.UseVisualStyleBackColor = true;
            this.radioButtonTimeOption.CheckedChanged += new System.EventHandler(this.radioButtonTimeOption_CheckedChanged);
            // 
            // radioButtonChooseBackupSet
            // 
            resources.ApplyResources(this.radioButtonChooseBackupSet, "radioButtonChooseBackupSet");
            this.radioButtonChooseBackupSet.Checked = true;
            this.radioButtonChooseBackupSet.Name = "radioButtonChooseBackupSet";
            this.radioButtonChooseBackupSet.TabStop = true;
            this.radioButtonChooseBackupSet.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.DisplayMember = "name";
            this.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPosition.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxPosition, "comboBoxPosition");
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.ValueMember = "name";
            this.comboBoxPosition.TextChanged += new System.EventHandler(this.comboBoxPosition_TextChanged);
            // 
            // buttonCancel
            // 
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            resources.ApplyResources(this.buttonOK, "buttonOK");
            this.buttonOK.Name = "buttonOK";
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
            resources.ApplyResources(this.panelDateAndTime, "panelDateAndTime");
            this.panelDateAndTime.Name = "panelDateAndTime";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            resources.ApplyResources(this.dateTimePickerTime, "dateTimePickerTime");
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.ShowUpDown = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dateTimePickerDate, "dateTimePickerDate");
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textBoxBackupDevice
            // 
            resources.ApplyResources(this.textBoxBackupDevice, "textBoxBackupDevice");
            this.textBoxBackupDevice.Name = "textBoxBackupDevice";
            this.textBoxBackupDevice.ReadOnly = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBoxDatabase
            // 
            resources.ApplyResources(this.textBoxDatabase, "textBoxDatabase");
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // statusStripProcessStats
            // 
            this.statusStripProcessStats.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripProcessStats.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelRestoring,
            this.toolStripProgressBarRestoring,
            this.toolStripStatusLabelPercent});
            resources.ApplyResources(this.statusStripProcessStats, "statusStripProcessStats");
            this.statusStripProcessStats.Name = "statusStripProcessStats";
            this.statusStripProcessStats.SizingGrip = false;
            // 
            // toolStripStatusLabelRestoring
            // 
            this.toolStripStatusLabelRestoring.Name = "toolStripStatusLabelRestoring";
            resources.ApplyResources(this.toolStripStatusLabelRestoring, "toolStripStatusLabelRestoring");
            this.toolStripStatusLabelRestoring.Spring = true;
            // 
            // toolStripProgressBarRestoring
            // 
            this.toolStripProgressBarRestoring.Name = "toolStripProgressBarRestoring";
            resources.ApplyResources(this.toolStripProgressBarRestoring, "toolStripProgressBarRestoring");
            // 
            // toolStripStatusLabelPercent
            // 
            resources.ApplyResources(this.toolStripStatusLabelPercent, "toolStripStatusLabelPercent");
            this.toolStripStatusLabelPercent.Name = "toolStripStatusLabelPercent";
            // 
            // RestoreForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStripProcessStats);
            this.Controls.Add(this.panelRestoreContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RestoreForm";
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