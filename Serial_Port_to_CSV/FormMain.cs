using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Serial_Port_to_CSV
{
    public partial class FormMain : Form
    {
        #region Fields

        SerialPortReader _serialReader;

        string _csvFilePath;

        DataTable _plotterData;

        int _plotCounter;

        #endregion

        #region Properties

        private bool IsFileWriting
        {
            get
            {
                return (0 == toolStripComboBoxWriteToFile.SelectedIndex);
            }
        }

        #endregion

        #region Constructors

        public FormMain()
        {
            InitializeComponent();
            InitializeSerialPort();
            InitializePlotter();

            toolStripComboBoxWriteToFile.SelectedIndex = 0;
        }

        #endregion

        #region EventHandlers

        private void toolStripButtonStart_Click(object sender, EventArgs e)
        {
            bool statusOK = true;

            if (IsFileWriting)
            {
                statusOK = false;
                statusOK = SetCSVFilePath();
            }

            if (statusOK)
            {
                _plotCounter = 0;
                chartPlotter.Series[0].Points.Clear();

                ChangeControlStates(false, true, false);
                _serialReader.Open();
            }
        }

        private void toolStripButtonStop_Click(object sender, EventArgs e)
        {
            ChangeControlStates(true, false, true);
            _serialReader.Close();
        }

        private void toolStripButtonClear_Click(object sender, EventArgs e)
        {
            listBoxMessages.Items.Clear();

            _plotCounter = 0;
            chartPlotter.Series[0].Points.Clear();
            _plotterData.Rows.Clear();
        }

        private void toolStripButtonConfigurations_Click(object sender, EventArgs e)
        {
            Configurations confWindow = new Configurations();
            confWindow.ShowDialog();
        }

        #endregion

        #region Methods - Private

        private void InitializePlotter()
        {
            _plotCounter = 0;
            _plotterData = new DataTable();
            _plotterData.Columns.Add("Point_X", typeof(double));
            _plotterData.Columns.Add("Signal_Y", typeof(double));

            chartPlotter.DataSource = _plotterData;
            chartPlotter.Series["Series1"].XValueMember = "Point_X";
            chartPlotter.Series["Series1"].YValueMembers = "Signal_Y";
            chartPlotter.Series["Series1"].ChartType = SeriesChartType.Line;
            chartPlotter.Series["Series1"].BorderWidth = 2;

            chartPlotter.ChartAreas[0].AxisY.LabelStyle.Format = "";
            chartPlotter.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chartPlotter.ChartAreas[0].AxisX.MajorGrid.LineWidth = 1;
            chartPlotter.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chartPlotter.ChartAreas[0].AxisY.MajorGrid.LineWidth = 1;
        }

        private void InitializeSerialPort()
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            string port = configuration.AppSettings.Settings[ConfigurationKeys.COM_PORT_KEY].Value;
            int baudRate = Convert.ToInt32(configuration.AppSettings.Settings[ConfigurationKeys.BAUD_RATE_KEY].Value);
            Parity parity = (Parity)Enum.Parse(typeof(Parity), configuration.AppSettings.Settings[ConfigurationKeys.PARITY_KEY].Value);
            int dataBits = Convert.ToInt32(configuration.AppSettings.Settings[ConfigurationKeys.DATA_BITS_KEY].Value);
            StopBits stopBits = (StopBits)Enum.Parse(typeof(StopBits), configuration.AppSettings.Settings[ConfigurationKeys.STOP_BITS_KEY].Value);

            _serialReader = new SerialPortReader(port, baudRate, parity, dataBits, stopBits);

            if (IsFileWriting)
            {
                _serialReader.AddOperation(new SerialPortReader.PerformOperation(WriteValueToFile));
            }

            _serialReader.AddOperation(new SerialPortReader.PerformOperation(WriteValueToListBox));
            _serialReader.AddOperation(new SerialPortReader.PerformOperation(WriteValueToPlotter));
        }

        private bool SetCSVFilePath()
        {
            bool result = false;

            if (DialogResult.OK == saveFileDialogCSVFile.ShowDialog())
            {
                _csvFilePath = saveFileDialogCSVFile.FileName;
                result = true;
            }

            return result;
        }

        private void ChangeControlStates(bool startButton, bool stopButton, bool configurationsButton)
        {
            toolStripButtonStart.Enabled = startButton;
            toolStripButtonStop.Enabled = stopButton;
            toolStripButtonConfigurations.Enabled = configurationsButton;
        }

        private void WriteValueToListBox(string value)
        {
            try
            {
                this.Invoke(new Action(() =>
                {
                    listBoxMessages.Items.Insert(0, value);
                }));
            }
            catch(Exception) { }
        }

        private void WriteValueToFile(string value)
        {
            this.Invoke(new Action(() =>
            {
                using (StreamWriter sWriter = new StreamWriter(_csvFilePath, true))
                {
                    sWriter.Write(value);
                }
            }));
        }

        private void WriteValueToPlotter(string value)
        {
            this.Invoke(new Action(() =>
            {
                try
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        if (value.Contains("\r"))
                        {
                            value = value.Replace("\r", "");
                        }

                        _plotterData.Rows.Add(_plotCounter, Convert.ToDouble(value));
                        chartPlotter.DataBind();

                        _plotCounter++;
                    }
                }
                catch(Exception) { }
            }));
        }

        #endregion
    }
}
