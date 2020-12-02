namespace Serial_Port_to_CSV
{
    partial class FormMain
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
            this.splitContainerToolbarMain = new System.Windows.Forms.SplitContainer();
            this.listBoxMessages = new System.Windows.Forms.ListBox();
            this.toolStripToolbar = new System.Windows.Forms.ToolStrip();
            this.saveFileDialogCSVFile = new System.Windows.Forms.SaveFileDialog();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonConfigurations = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClear = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerToolbarMain)).BeginInit();
            this.splitContainerToolbarMain.Panel1.SuspendLayout();
            this.splitContainerToolbarMain.Panel2.SuspendLayout();
            this.splitContainerToolbarMain.SuspendLayout();
            this.toolStripToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerToolbarMain
            // 
            this.splitContainerToolbarMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerToolbarMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerToolbarMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerToolbarMain.IsSplitterFixed = true;
            this.splitContainerToolbarMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerToolbarMain.Name = "splitContainerToolbarMain";
            this.splitContainerToolbarMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerToolbarMain.Panel1
            // 
            this.splitContainerToolbarMain.Panel1.Controls.Add(this.toolStripToolbar);
            // 
            // splitContainerToolbarMain.Panel2
            // 
            this.splitContainerToolbarMain.Panel2.Controls.Add(this.listBoxMessages);
            this.splitContainerToolbarMain.Size = new System.Drawing.Size(846, 387);
            this.splitContainerToolbarMain.SplitterDistance = 40;
            this.splitContainerToolbarMain.SplitterWidth = 2;
            this.splitContainerToolbarMain.TabIndex = 0;
            // 
            // listBoxMessages
            // 
            this.listBoxMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxMessages.FormattingEnabled = true;
            this.listBoxMessages.ItemHeight = 16;
            this.listBoxMessages.Location = new System.Drawing.Point(0, 0);
            this.listBoxMessages.Name = "listBoxMessages";
            this.listBoxMessages.Size = new System.Drawing.Size(844, 343);
            this.listBoxMessages.TabIndex = 0;
            // 
            // toolStripToolbar
            // 
            this.toolStripToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripToolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripToolbar.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStripToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonStart,
            this.toolStripButtonStop,
            this.toolStripButtonConfigurations,
            this.toolStripSeparator1,
            this.toolStripButtonClear});
            this.toolStripToolbar.Location = new System.Drawing.Point(0, 0);
            this.toolStripToolbar.Name = "toolStripToolbar";
            this.toolStripToolbar.Size = new System.Drawing.Size(844, 38);
            this.toolStripToolbar.TabIndex = 0;
            // 
            // saveFileDialogCSVFile
            // 
            this.saveFileDialogCSVFile.DefaultExt = "csv";
            this.saveFileDialogCSVFile.Filter = "Comma Separated Value Files|*.csv";
            this.saveFileDialogCSVFile.InitialDirectory = "C:\\";
            this.saveFileDialogCSVFile.RestoreDirectory = true;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripButtonStart
            // 
            this.toolStripButtonStart.Image = global::Serial_Port_to_CSV.Properties.Resources.Oxygen_Start_Icon_128_128_1;
            this.toolStripButtonStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStart.Name = "toolStripButtonStart";
            this.toolStripButtonStart.Size = new System.Drawing.Size(65, 35);
            this.toolStripButtonStart.Text = "Start";
            this.toolStripButtonStart.Click += new System.EventHandler(this.toolStripButtonStart_Click);
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.Enabled = false;
            this.toolStripButtonStop.Image = global::Serial_Port_to_CSV.Properties.Resources.Oxygen_Stop_Icon_128_128_1;
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Size = new System.Drawing.Size(65, 35);
            this.toolStripButtonStop.Text = "Stop";
            this.toolStripButtonStop.Click += new System.EventHandler(this.toolStripButtonStop_Click);
            // 
            // toolStripButtonConfigurations
            // 
            this.toolStripButtonConfigurations.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonConfigurations.Image = global::Serial_Port_to_CSV.Properties.Resources.Advanced_Configuration_128_128_1;
            this.toolStripButtonConfigurations.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonConfigurations.Name = "toolStripButtonConfigurations";
            this.toolStripButtonConfigurations.Size = new System.Drawing.Size(120, 35);
            this.toolStripButtonConfigurations.Text = "Configurations";
            this.toolStripButtonConfigurations.Click += new System.EventHandler(this.toolStripButtonConfigurations_Click);
            // 
            // toolStripButtonClear
            // 
            this.toolStripButtonClear.Image = global::Serial_Port_to_CSV.Properties.Resources.Oxygen_Clear_Icon_128_128_1;
            this.toolStripButtonClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClear.Name = "toolStripButtonClear";
            this.toolStripButtonClear.Size = new System.Drawing.Size(68, 35);
            this.toolStripButtonClear.Text = "Clear";
            this.toolStripButtonClear.Click += new System.EventHandler(this.toolStripButtonClear_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 387);
            this.Controls.Add(this.splitContainerToolbarMain);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Port Reader";
            this.splitContainerToolbarMain.Panel1.ResumeLayout(false);
            this.splitContainerToolbarMain.Panel1.PerformLayout();
            this.splitContainerToolbarMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerToolbarMain)).EndInit();
            this.splitContainerToolbarMain.ResumeLayout(false);
            this.toolStripToolbar.ResumeLayout(false);
            this.toolStripToolbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerToolbarMain;
        private System.Windows.Forms.ListBox listBoxMessages;
        private System.Windows.Forms.ToolStrip toolStripToolbar;
        private System.Windows.Forms.ToolStripButton toolStripButtonStart;
        private System.Windows.Forms.ToolStripButton toolStripButtonStop;
        private System.Windows.Forms.ToolStripButton toolStripButtonConfigurations;
        private System.Windows.Forms.SaveFileDialog saveFileDialogCSVFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonClear;
    }
}

