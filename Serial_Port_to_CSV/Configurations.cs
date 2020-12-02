using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.Configuration;

namespace Serial_Port_to_CSV
{
    public partial class Configurations : Form
    {
        #region Fields

        private int[] _baudRates = { 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 28800, 31250, 38400, 57600, 115200 };

        private int[] _databits = { 5, 6, 7, 8 };

        #endregion

        #region Constructors

        public Configurations()
        {
            InitializeComponent();

            InitializePorts();
            InitializeBaudRates();
            InitializeParity();
            InitializeDataBits();
            InitializeStopBits();

            LoadConfigurations();
        }

        #endregion

        #region EventHandlers

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            SaveConfigurations();
            this.Close();
        }

        private void toolStripButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Methods - Private

        private void InitializePorts()
        {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
           
            if (null != ports)
            {
                comboBoxPorts.Items.Clear();

                foreach (string port in ports)
                {
                    comboBoxPorts.Items.Add(port);
                }
            }
        }

        private void InitializeBaudRates()
        {
            comboBoxBaudRates.Items.Clear();

            foreach (int rate in _baudRates)
            {
                comboBoxBaudRates.Items.Add(rate);
            }
        }

        private void InitializeParity()
        {
            comboBoxParity.Items.Clear();

            string[] parityList = Enum.GetNames(typeof(Parity));
            foreach (string parity in parityList)
            {
                comboBoxParity.Items.Add(parity);
            }
        }

        private void InitializeDataBits()
        {
            comboBoxDataBits.Items.Clear();

            foreach (int bit in _databits)
            {
                comboBoxDataBits.Items.Add(bit);
            }
        }

        private void InitializeStopBits()
        {
            comboBoxStopBits.Items.Clear();

            string[] stopBits = Enum.GetNames(typeof(StopBits));
            foreach (string bit in stopBits)
            {
                comboBoxStopBits.Items.Add(bit);
            }
        }


        private void LoadConfigurations()
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            SelectComboBoxValue(comboBoxPorts, configuration.AppSettings.Settings[ConfigurationKeys.COM_PORT_KEY].Value);
            SelectComboBoxValue(comboBoxBaudRates, configuration.AppSettings.Settings[ConfigurationKeys.BAUD_RATE_KEY].Value);
            SelectComboBoxValue(comboBoxParity, configuration.AppSettings.Settings[ConfigurationKeys.PARITY_KEY].Value);
            SelectComboBoxValue(comboBoxDataBits, configuration.AppSettings.Settings[ConfigurationKeys.DATA_BITS_KEY].Value);
            SelectComboBoxValue(comboBoxStopBits, configuration.AppSettings.Settings[ConfigurationKeys.STOP_BITS_KEY].Value);
        }

        private void SaveConfigurations()
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            configuration.AppSettings.Settings.Remove(ConfigurationKeys.COM_PORT_KEY);
            configuration.AppSettings.Settings.Remove(ConfigurationKeys.BAUD_RATE_KEY);
            configuration.AppSettings.Settings.Remove(ConfigurationKeys.PARITY_KEY);
            configuration.AppSettings.Settings.Remove(ConfigurationKeys.DATA_BITS_KEY);
            configuration.AppSettings.Settings.Remove(ConfigurationKeys.STOP_BITS_KEY);

            configuration.AppSettings.Settings.Add(ConfigurationKeys.COM_PORT_KEY, comboBoxPorts.Items[comboBoxPorts.SelectedIndex].ToString());
            configuration.AppSettings.Settings.Add(ConfigurationKeys.BAUD_RATE_KEY, comboBoxBaudRates.Items[comboBoxBaudRates.SelectedIndex].ToString());
            configuration.AppSettings.Settings.Add(ConfigurationKeys.PARITY_KEY, comboBoxParity.Items[comboBoxParity.SelectedIndex].ToString());
            configuration.AppSettings.Settings.Add(ConfigurationKeys.DATA_BITS_KEY, comboBoxDataBits.Items[comboBoxDataBits.SelectedIndex].ToString());
            configuration.AppSettings.Settings.Add(ConfigurationKeys.STOP_BITS_KEY, comboBoxStopBits.Items[comboBoxStopBits.SelectedIndex].ToString());

            configuration.Save();
        }

        private void SelectComboBoxValue(ComboBox comboBox, string value)
        {
            if (0 < comboBox.Items.Count)
            {
                for (int i = 0; i < comboBox.Items.Count; i++)
                {
                    if(value == comboBox.Items[i].ToString())
                    {
                        comboBox.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        #endregion
    }
}
