using System;
using System.Configuration;
using System.IO.Ports;

namespace FirstTask
{
    class Config
    {

        public int BaudRate { get; set; }
        public Parity parity { get; set; }
        public StopBits stopBits { get; set; }
        public int DataBits { get; set; }
        public Handshake handshake { get; set; }
        public bool RtsEnable { get; set; }


        public SerialPort SetConfig(SerialPort _serialPort)
        {
            return _serialPort;         
        }
    }
}
