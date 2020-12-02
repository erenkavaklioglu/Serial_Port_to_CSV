using System;
using System.Configuration;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;

namespace Serial_Port_to_CSV
{
    public partial class FormMain : Form
    {
        #region Fields

        SerialPortReader _serialReader;

        string _csvFilePath;

        #endregion

        #region Constructors

        public FormMain()
        {
            InitializeComponent();
            InitializeSerialPort();
        }

        #endregion

        #region EventHandlers

        private void toolStripButtonStart_Click(object sender, EventArgs e)
        {
            if (SetCSVFilePath())
            {
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
        }

        private void toolStripButtonConfigurations_Click(object sender, EventArgs e)
        {
            Configurations confWindow = new Configurations();
            confWindow.ShowDialog();
        }

        #endregion

        #region Methods - Private

        private void InitializeSerialPort()
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            string port = configuration.AppSettings.Settings[ConfigurationKeys.COM_PORT_KEY].Value;
            int baudRate = Convert.ToInt32(configuration.AppSettings.Settings[ConfigurationKeys.BAUD_RATE_KEY].Value);
            Parity parity = (Parity)Enum.Parse(typeof(Parity), configuration.AppSettings.Settings[ConfigurationKeys.PARITY_KEY].Value);
            int dataBits = Convert.ToInt32(configuration.AppSettings.Settings[ConfigurationKeys.DATA_BITS_KEY].Value);
            StopBits stopBits = (StopBits)Enum.Parse(typeof(StopBits), configuration.AppSettings.Settings[ConfigurationKeys.STOP_BITS_KEY].Value);

            _serialReader = new SerialPortReader(port, baudRate, parity, dataBits, stopBits);

            _serialReader.AddOperation(new SerialPortReader.PerformOperation(WriteValueToFile));
            _serialReader.AddOperation(new SerialPortReader.PerformOperation(WriteValueToListBox));
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
            this.Invoke(new Action(() =>
            {
                listBoxMessages.Items.Insert(0, value);
            }));
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

        #endregion
    }
}
