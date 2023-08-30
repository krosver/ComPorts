using System.IO.Ports;

namespace FirstTask
{
    class COM
    {
        private SerialPort _serialPort;
        private Config _config = new Config();
        public delegate void DataReceived(string comMsg);
        public static event DataReceived onDataReceived;
        public COM(string portName)
        {
            _serialPort = new SerialPort(portName);
            _serialPort = _config.SetConfig(_serialPort);
            _serialPort.DataReceived+= new SerialDataReceivedEventHandler(SerialPort_DataReceived);
            NewComPort(portName);
        }
        public void NewComPort(string portName) 
        {
            Close();
            _serialPort.PortName = portName;
            Open();
        }
        private void Open() => _serialPort.Open();
        private void Close()
        {
            if (_serialPort.IsOpen) 
                _serialPort.Close();
        } 
        private string GetMsg() => _serialPort.ReadExisting();
        public void SetMsg(string msg) => _serialPort.WriteLine(msg);
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            onDataReceived?.Invoke(GetMsg());
        }
    }
}
