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
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Security.Authentication.ExtendedProtection;
using System.Diagnostics.Eventing.Reader;

namespace FirstTask
{
    public partial class Form1 : Form
    {
        bool ide => bit29.Checked;
        bool rtr => RTR.Checked;
        int id; //=> int.Parse(ID.Text, NumberStyles.HexNumber);
        byte dlc => Convert.ToByte(DLC.Text);
        string comment => Comment.Text;
        int[] data => new int[] 
        {   int.Parse(Data1.Text, NumberStyles.HexNumber), 
            int.Parse(Data2.Text, NumberStyles.HexNumber),
            int.Parse(Data3.Text, NumberStyles.HexNumber),
            int.Parse(Data4.Text, NumberStyles.HexNumber),
            int.Parse(Data5.Text, NumberStyles.HexNumber),
            int.Parse(Data6.Text, NumberStyles.HexNumber),
            int.Parse(Data7.Text, NumberStyles.HexNumber),
            int.Parse(Data8.Text, NumberStyles.HexNumber),
        };
        string channel => COMs.Text.Trim();


        CAN_Message message;

        private Config config;

        private string[] ports => SerialPort.GetPortNames();
        private TextBox[] dataBoxes;
        private SerialPort serialPort;
        public Form1()
        {
            InitializeComponent();
            GetAllPorst();
            config = JsonSerializer.Deserialize<Config>(File.OpenRead("config.json"));
            dataBoxes = new TextBox[] { Data1, Data2, Data3, Data4, Data5, Data6, Data7, Data8 };
            SerialPortsFunction();
        }
        private void SerialPortsFunction()
        {
            serialPort = new SerialPort("COM5", 9600); // Укажите нужные параметры порта
            try
            {
                // Открываем порт
                serialPort.Open();

                // Присоединяем обработчик события при получении данных
                serialPort.DataReceived += SerialPort_DataReceived;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                // Закрываем порт при завершении программы
                if (serialPort.IsOpen)
                    serialPort.Close();
            }
        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Обработчик события при получении данных с порта
            SerialPort sp = (SerialPort)sender;

            // Читаем все доступные данные из порта
            string data = sp.ReadExisting();

            CAN_Message msg;
            msg = new CAN_Message(data);
            listView1.Items.Add(msg);

        }
        private void SendData(string data)
        {
            try
            {
                // Отправляем данные по COM-порту
                serialPort.Write(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при отправке данных: " + ex.Message);
            }
        }
        private void GetAllPorst()
        {
            COMs.Items.Clear();
            COMs.Items.AddRange(ports);

        }
        private void SetMessageButton_click(object sender, EventArgs e)
        {
            if (int.TryParse(ID.Text, out int id)) { }
            else
            {
                CultureInfo provider = new CultureInfo("en-US");
                id = int.Parse(ID.Text, NumberStyles.HexNumber);
            }

            message = new CAN_Message(channel, id, ide, rtr, dlc, data, comment);
            listView2.Items.Add(message);
            //listView1.Items.Add(message);
            SendData(message.To_Binary());
        }

        private void DLC_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(DLC.Text, out var dlc);
            if (dlc != 9)
            {
                for (int i = 0; i < dlc; i++)
                {
                    dataBoxes[i].Enabled = true;
                }
                for (int i = dlc; i < 8; i++)
                {
                    dataBoxes[i].Enabled = false;
                    dataBoxes[i].Text = "00";
                }
            }
            else
                DLC.Text = "8";
        }

        private void Data_TextChanged(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb.Text.Length > 0)
            {
                CultureInfo provider = new CultureInfo("en-US");
                var isInt = int.TryParse(tb.Text, NumberStyles.HexNumber, provider, out var dlc);
                // Проверяем, являются ли данные 16-ричным числом
                if (!isInt)
                {
                    MessageBox.Show("Неверный формат числа");
                    tb.Text = "00";
                }
            }
        }


        private void bit29_CheckedChanged(object sender, EventArgs e)
        {
            if (ide)
            {
                // ID 29 бит
                ID.Text = ID.Text.PadLeft(8, '0');
                ID.MaxLength = 8;
            }
            else
            {
                // ID 11 бит
                ID.Text = ID.Text.Substring(ID.Text.Length - 3);
                ID.MaxLength = 3;
            }
        }


        private void ID_TextChanged(object sender, EventArgs e)
        {
            if (ID.Text.Length > 0)
            {
                CultureInfo provider = new CultureInfo("en-US");
                var isInt = int.TryParse(ID.Text, NumberStyles.HexNumber, provider, out var dlc);
                // Проверяем, являются ли данные 16-ричным числом
                if (!isInt)
                {
                    MessageBox.Show("Неверный формат числа");
                    ID.Text = "";
                }
            }
        }
    }
}
