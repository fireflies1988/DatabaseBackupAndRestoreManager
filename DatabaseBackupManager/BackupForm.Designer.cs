
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupForm));
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
            resources.ApplyResources(this.statusStripProcessStats, "statusStripProcessStats");
            this.statusStripProcessStats.Name = "statusStripProcessStats";
            this.statusStripProcessStats.SizingGrip = false;
            // 
            // toolStripStatusLabelBackingUp
            // 
            this.toolStripStatusLabelBackingUp.Name = "toolStripStatusLabelBackingUp";
            resources.ApplyResources(this.toolStripStatusLabelBackingUp, "toolStripStatusLabelBackingUp");
            this.toolStripStatusLabelBackingUp.Spring = true;
            // 
            // toolStripProgressBarBackingUp
            // 
            this.toolStripProgressBarBackingUp.Name = "toolStripProgressBarBackingUp";
            resources.ApplyResources(this.toolStripProgressBarBackingUp, "toolStripProgressBarBackingUp");
            // 
            // toolStripStatusLabelPercent
            // 
            this.toolStripStatusLabelPercent.Name = "toolStripStatusLabelPercent";
            resources.ApplyResources(this.toolStripStatusLabelPercent, "toolStripStatusLabelPercent");
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
            resources.ApplyResources(this.panelBackupContent, "panelBackupContent");
            this.panelBackupContent.Name = "panelBackupContent";
            // 
            // textBoxDescription
            // 
            resources.ApplyResources(this.textBoxDescription, "textBoxDescription");
            this.textBoxDescription.Name = "textBoxDescription";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
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
            // textBoxName
            // 
            resources.ApplyResources(this.textBoxName, "textBoxName");
            this.textBoxName.Name = "textBoxName";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonOverwrite);
            this.panel2.Controls.Add(this.radioButtonAppend);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // radioButtonOverwrite
            // 
            resources.ApplyResources(this.radioButtonOverwrite, "radioButtonOverwrite");
            this.radioButtonOverwrite.Name = "radioButtonOverwrite";
            this.radioButtonOverwrite.UseVisualStyleBackColor = true;
            // 
            // radioButtonAppend
            // 
            resources.ApplyResources(this.radioButtonAppend, "radioButtonAppend");
            this.radioButtonAppend.Checked = true;
            this.radioButtonAppend.Name = "radioButtonAppend";
            this.radioButtonAppend.TabStop = true;
            this.radioButtonAppend.UseVisualStyleBackColor = true;
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
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
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
            // BackupForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBackupContent);
            this.Controls.Add(this.statusStripProcessStats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackupForm";
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