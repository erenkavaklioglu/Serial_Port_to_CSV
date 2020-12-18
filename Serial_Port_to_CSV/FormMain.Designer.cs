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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainerToolbarMain = new System.Windows.Forms.SplitContainer();
            this.toolStripToolbar = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonConfigurations = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonClear = new System.Windows.Forms.ToolStripButton();
            this.listBoxMessages = new System.Windows.Forms.ListBox();
            this.saveFileDialogCSVFile = new System.Windows.Forms.SaveFileDialog();
            this.splitContainerListPlotter = new System.Windows.Forms.SplitContainer();
            this.chartPlotter = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStripComboBoxWriteToFile = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerToolbarMain)).BeginInit();
            this.splitContainerToolbarMain.Panel1.SuspendLayout();
            this.splitContainerToolbarMain.Panel2.SuspendLayout();
            this.splitContainerToolbarMain.SuspendLayout();
            this.toolStripToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerListPlotter)).BeginInit();
            this.splitContainerListPlotter.Panel1.SuspendLayout();
            this.splitContainerListPlotter.Panel2.SuspendLayout();
            this.splitContainerListPlotter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPlotter)).BeginInit();
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
            this.splitContainerToolbarMain.Panel2.Controls.Add(this.splitContainerListPlotter);
            this.splitContainerToolbarMain.Size = new System.Drawing.Size(846, 387);
            this.splitContainerToolbarMain.SplitterDistance = 40;
            this.splitContainerToolbarMain.SplitterWidth = 2;
            this.splitContainerToolbarMain.TabIndex = 0;
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
            this.toolStripButtonClear,
            this.toolStripComboBoxWriteToFile});
            this.toolStripToolbar.Location = new System.Drawing.Point(0, 0);
            this.toolStripToolbar.Name = "toolStripToolbar";
            this.toolStripToolbar.Size = new System.Drawing.Size(844, 38);
            this.toolStripToolbar.TabIndex = 0;
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
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
            // listBoxMessages
            // 
            this.listBoxMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxMessages.FormattingEnabled = true;
            this.listBoxMessages.ItemHeight = 16;
            this.listBoxMessages.Location = new System.Drawing.Point(0, 0);
            this.listBoxMessages.Name = "listBoxMessages";
            this.listBoxMessages.Size = new System.Drawing.Size(298, 343);
            this.listBoxMessages.TabIndex = 0;
            // 
            // saveFileDialogCSVFile
            // 
            this.saveFileDialogCSVFile.DefaultExt = "csv";
            this.saveFileDialogCSVFile.Filter = "Comma Separated Value Files|*.csv";
            this.saveFileDialogCSVFile.InitialDirectory = "C:\\";
            this.saveFileDialogCSVFile.RestoreDirectory = true;
            // 
            // splitContainerListPlotter
            // 
            this.splitContainerListPlotter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerListPlotter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerListPlotter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerListPlotter.IsSplitterFixed = true;
            this.splitContainerListPlotter.Location = new System.Drawing.Point(0, 0);
            this.splitContainerListPlotter.Name = "splitContainerListPlotter";
            // 
            // splitContainerListPlotter.Panel1
            // 
            this.splitContainerListPlotter.Panel1.Controls.Add(this.listBoxMessages);
            // 
            // splitContainerListPlotter.Panel2
            // 
            this.splitContainerListPlotter.Panel2.Controls.Add(this.chartPlotter);
            this.splitContainerListPlotter.Size = new System.Drawing.Size(846, 345);
            this.splitContainerListPlotter.SplitterDistance = 300;
            this.splitContainerListPlotter.SplitterWidth = 2;
            this.splitContainerListPlotter.TabIndex = 1;
            // 
            // chartPlotter
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPlotter.ChartAreas.Add(chartArea1);
            this.chartPlotter.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartPlotter.Legends.Add(legend1);
            this.chartPlotter.Location = new System.Drawing.Point(0, 0);
            this.chartPlotter.Name = "chartPlotter";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPlotter.Series.Add(series1);
            this.chartPlotter.Size = new System.Drawing.Size(542, 343);
            this.chartPlotter.TabIndex = 0;
            this.chartPlotter.Text = "chart1";
            // 
            // toolStripComboBoxWriteToFile
            // 
            this.toolStripComboBoxWriteToFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxWriteToFile.Items.AddRange(new object[] {
            "Write To File",
            "Only Screen"});
            this.toolStripComboBoxWriteToFile.Name = "toolStripComboBoxWriteToFile";
            this.toolStripComboBoxWriteToFile.Size = new System.Drawing.Size(121, 38);
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
            this.splitContainerListPlotter.Panel1.ResumeLayout(false);
            this.splitContainerListPlotter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerListPlotter)).EndInit();
            this.splitContainerListPlotter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPlotter)).EndInit();
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
        private System.Windows.Forms.SplitContainer splitContainerListPlotter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPlotter;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxWriteToFile;
    }
}

