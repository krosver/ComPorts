using System.Windows.Forms;
using System.IO.Ports;
using static FirstTask.COM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.IO;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FirstTask
{
    public partial class Form1 : Form
    {
        private Config config;
        private Dictionary<string, string> msgData = new Dictionary<string, string>()
        {
            {"CH",""},
            {"Флаги",""},
            {"ID",""},
            {"DLC",""},
            {"Данные",""},
            {"Период",""},
            {"Счетчик",""},
            {"ASCII",""},
            {"Коментарий",""},
        };
        private string[] ports;
        private Keys[] correctKeys = new Keys[]
            {
                Keys.A, Keys.B, Keys.C,Keys.D,Keys.E,Keys.F,
                Keys.D0,Keys.D1,Keys.D2,Keys.D3,Keys.D4,Keys.D5,Keys.D6,Keys.D7,Keys.D8,Keys.D9
            };
        private bool nonNumberEntered;
        public Form1()
        {
            InitializeComponent();
            GetAllPorst();
            config = JsonSerializer.Deserialize<Config>(File.OpenRead("config.json"));
        }
        private void AddMessage(ListView listView)
        {
            ListViewItem message = new ListViewItem(msgData["CH"]);
            message.SubItems.Add(msgData["Флаги"]);
            message.SubItems.Add(msgData["ID"]);
            message.SubItems.Add(msgData["DLC"]);
            message.SubItems.Add(msgData["Данные"]);
            message.SubItems.Add(msgData["Период"]);
            message.SubItems.Add(msgData["Счетчик"]);
            message.SubItems.Add(msgData["ASCII"]);
            message.SubItems.Add(msgData["Коментарий"]);
            listView.Items.Add(message);
        }
        private void GetAllPorst()
        {
            if (SerialPort.GetPortNames().Length != 0)
            {
                ports = SerialPort.GetPortNames();
            }
            COMs.Items.Clear();
            trigger_com.Items.Clear();

            COMs.Items.AddRange(ports);

            trigger_com.Items.Add("Все");
            trigger_com.Items.AddRange(ports);
        }
        #region Проверка на ввод 16-ричной системы
        private void EnteringNumber(object sender, KeyEventArgs e)
        {
            nonNumberEntered = true;
            if (correctKeys.Contains(e.KeyCode) || e.KeyCode == Keys.Shift || e.KeyCode == Keys.Back)
            {
                nonNumberEntered = false;
            }
        }
        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
            }
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            ToBinary("Hello world");
            Msg msg = new Msg();
            msg.CH = COMs.Text;
            msg.Flags = "COM";
            msg.ID = int.Parse(ID.Text);
            msg.DLC = int.Parse(DLC.Text);
            msg.Data = Data1.Text + Data2.Text + Data3.Text + Data4.Text + Data5.Text + Data6.Text + Data7.Text + Data8.Text;
            msg.Comment = Comment.Text;
            msg.RTR = RTR.Checked;
            msg.Bit29 = bit29.Checked;
            var a = int.Parse(Data1.Text, NumberStyles.HexNumber);
        }
        private byte[] ToBinary(string str)
        {
            
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(str);
            return bytes;
        }

        private void Main()
        {
            var port = new SerialPort("COM5");
            port.Open();

            try
            {
                while (true)
                {
                    //Message message = await ReadWholeMessage(port.BaseStream);
                }
            }
            catch (OperationCanceledException) { /*нас остановили, выходим */ }
            catch (ObjectDisposedException) { /* тоже остановили */ }
            catch (IOException ex)
            {
                // а вот это проблема, логируем и бросаем дальше
            }
            catch (InvalidDataException ex)
            {
                // девайс вернул не то, логируем, нужна повторная инициализация
            }
        }
        async Task<Message> ReadWholeMessage(Stream stream)
        {
            var headerBytes = await StreamHelpers.ReadAsync(stream, 3);
            var type = headerBytes[0];
            var stringSize = BitConverter.ToUInt16(headerBytes, 1);
            var stringBytes = await StreamHelpers.ReadAsync(stream, stringSize);
            var crc = (await StreamHelpers.ReadAsync(stream, 1))[0];
            // тут проверка crc
            var text = Encoding.ASCII.GetString(stringBytes);
            var message = new Message() { Type = type, Text = text };
            return message;
        }
        public static class StreamHelpers
        {
            static public async Task<byte[]> ReadAsync(Stream s, int nBytes)
            {
                var buf = new byte[nBytes];
                var readpos = 0;
                while (readpos < nBytes)
                {
                    var actuallyRead = await s.ReadAsync(buf, readpos, nBytes - readpos);
                    if (actuallyRead == 0)
                        throw new EndOfStreamException();
                    readpos += actuallyRead;
                }
                return buf;
            }
        }
    }
}
