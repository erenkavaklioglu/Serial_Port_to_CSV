namespace Serial_Port_to_CSV
{
    partial class Configurations
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
            this.toolStripToolbar = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancel = new System.Windows.Forms.ToolStripButton();
            this.labelPort = new System.Windows.Forms.Label();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.comboBoxBaudRates = new System.Windows.Forms.ComboBox();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.labelParity = new System.Windows.Forms.Label();
            this.labelDataBits = new System.Windows.Forms.Label();
            this.labelStopBits = new System.Windows.Forms.Label();
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
            this.splitContainerToolbarMain.Panel2.Controls.Add(this.comboBoxStopBits);
            this.splitContainerToolbarMain.Panel2.Controls.Add(this.comboBoxDataBits);
            this.splitContainerToolbarMain.Panel2.Controls.Add(this.comboBoxParity);
            this.splitContainerToolbarMain.Panel2.Controls.Add(this.comboBoxBaudRates);
            this.splitContainerToolbarMain.Panel2.Controls.Add(this.labelStopBits);
            this.splitContainerToolbarMain.Panel2.Controls.Add(this.labelDataBits);
            this.splitContainerToolbarMain.Panel2.Controls.Add(this.labelParity);
            this.splitContainerToolbarMain.Panel2.Controls.Add(this.labelBaudRate);
            this.splitContainerToolbarMain.Panel2.Controls.Add(this.comboBoxPorts);
            this.splitContainerToolbarMain.Panel2.Controls.Add(this.labelPort);
            this.splitContainerToolbarMain.Size = new System.Drawing.Size(299, 236);
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
            this.toolStripButtonSave,
            this.toolStripButtonCancel});
            this.toolStripToolbar.Location = new System.Drawing.Point(0, 0);
            this.toolStripToolbar.Name = "toolStripToolbar";
            this.toolStripToolbar.Size = new System.Drawing.Size(297, 38);
            this.toolStripToolbar.TabIndex = 0;
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Image = global::Serial_Port_to_CSV.Properties.Resources.Oxygen_File_Save_Icon_128_128_1;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(65, 35);
            this.toolStripButtonSave.Text = "Save";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonCancel
            // 
            this.toolStripButtonCancel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonCancel.Image = global::Serial_Port_to_CSV.Properties.Resources.Oxygen_Delete_Icon_128_128_1;
            this.toolStripButtonCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancel.Name = "toolStripButtonCancel";
            this.toolStripButtonCancel.Size = new System.Drawing.Size(77, 35);
            this.toolStripButtonCancel.Text = "Cancel";
            this.toolStripButtonCancel.Click += new System.EventHandler(this.toolStripButtonCancel_Click);
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPort.Location = new System.Drawing.Point(27, 25);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(34, 17);
            this.labelPort.TabIndex = 0;
            this.labelPort.Text = "Port";
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(140, 22);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPorts.TabIndex = 1;
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBaudRate.Location = new System.Drawing.Point(27, 55);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(75, 17);
            this.labelBaudRate.TabIndex = 2;
            this.labelBaudRate.Text = "Baud Rate";
            // 
            // comboBoxBaudRates
            // 
            this.comboBoxBaudRates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaudRates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxBaudRates.FormattingEnabled = true;
            this.comboBoxBaudRates.Location = new System.Drawing.Point(140, 52);
            this.comboBoxBaudRates.Name = "comboBoxBaudRates";
            this.comboBoxBaudRates.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBaudRates.TabIndex = 3;
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Location = new System.Drawing.Point(140, 82);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(121, 24);
            this.comboBoxParity.TabIndex = 3;
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Location = new System.Drawing.Point(140, 112);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDataBits.TabIndex = 3;
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStopBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Location = new System.Drawing.Point(140, 142);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStopBits.TabIndex = 3;
            // 
            // labelParity
            // 
            this.labelParity.AutoSize = true;
            this.labelParity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelParity.Location = new System.Drawing.Point(27, 85);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(44, 17);
            this.labelParity.TabIndex = 2;
            this.labelParity.Text = "Parity";
            // 
            // labelDataBits
            // 
            this.labelDataBits.AutoSize = true;
            this.labelDataBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDataBits.Location = new System.Drawing.Point(27, 115);
            this.labelDataBits.Name = "labelDataBits";
            this.labelDataBits.Size = new System.Drawing.Size(65, 17);
            this.labelDataBits.TabIndex = 2;
            this.labelDataBits.Text = "Data Bits";
            // 
            // labelStopBits
            // 
            this.labelStopBits.AutoSize = true;
            this.labelStopBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelStopBits.Location = new System.Drawing.Point(27, 145);
            this.labelStopBits.Name = "labelStopBits";
            this.labelStopBits.Size = new System.Drawing.Size(64, 17);
            this.labelStopBits.TabIndex = 2;
            this.labelStopBits.Text = "Stop Bits";
            // 
            // Configurations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 236);
            this.Controls.Add(this.splitContainerToolbarMain);
            this.Name = "Configurations";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurations";
            this.splitContainerToolbarMain.Panel1.ResumeLayout(false);
            this.splitContainerToolbarMain.Panel1.PerformLayout();
            this.splitContainerToolbarMain.Panel2.ResumeLayout(false);
            this.splitContainerToolbarMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerToolbarMain)).EndInit();
            this.splitContainerToolbarMain.ResumeLayout(false);
            this.toolStripToolbar.ResumeLayout(false);
            this.toolStripToolbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerToolbarMain;
        private System.Windows.Forms.ToolStrip toolStripToolbar;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancel;
        private System.Windows.Forms.ComboBox comboBoxBaudRates;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.Label labelStopBits;
        private System.Windows.Forms.Label labelDataBits;
        private System.Windows.Forms.Label labelParity;
    }
}