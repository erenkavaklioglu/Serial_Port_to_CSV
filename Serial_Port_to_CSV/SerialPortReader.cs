using System.Collections.Generic;
using System.IO.Ports;

namespace Serial_Port_to_CSV
{
    class SerialPortReader
    {
        #region Delegates

        public delegate void PerformOperation(string value);

        #endregion

        #region Fields

        SerialPort _serialPort;

        List<PerformOperation> _operationList;

        #endregion

        #region Constructors

        public SerialPortReader(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits)
        {
            _serialPort = new SerialPort(portName, baudRate, parity, dataBits, stopBits);
            _serialPort.DataReceived += _serialPort_DataReceived;

            _operationList = new List<PerformOperation>();
        }

        #endregion

        #region EventHandlers

        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            ReadSerialPort();
        }

        #endregion

        #region Methods - Public

        public void Open()
        {
            _serialPort.Open();
        }

        public void Close()
        {
            _serialPort.Close();
        }

        public void AddOperation(PerformOperation operation)
        {
            if (null != operation)
            {
                _operationList.Add(operation);
            }
        }

        public void AddEventHandler(SerialDataReceivedEventHandler handler)
        {
            if (null != _serialPort)
            {
                _serialPort.DataReceived += handler;
            }
        }

        #endregion

        #region Methods - Private

        private void ReadSerialPort()
        {
            if (_serialPort.IsOpen)
            {
                string line = _serialPort.ReadLine();

                if (!string.IsNullOrEmpty(line))
                {
                    PerformOperations(line);
                }
            }
        }

        private void PerformOperations(string value)
        {
            if (null != _operationList && 0 < _operationList.Count)
            {
                foreach (PerformOperation operation in _operationList)
                {
                    operation(value);
                }
            }
        }

        #endregion
    }
}
