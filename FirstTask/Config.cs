using System.IO.Ports;

namespace FirstTask
{
    class Config
    {
        
        public const int BaudRate = 9600;
        public const Parity parity = Parity.None;
        public const StopBits stopBits = StopBits.One;
        public const int DataBits = 8;


        public SerialPort SetConfig(SerialPort _serialPort) 
        {
            _serialPort.BaudRate = Config.BaudRate;
            _serialPort.Parity = Config.parity;
            _serialPort.StopBits = Config.stopBits;
            _serialPort.DataBits = Config.DataBits;
            _serialPort.Handshake = Handshake.None;
            _serialPort.RtsEnable = true;
            return _serialPort;
        }
    }
}
