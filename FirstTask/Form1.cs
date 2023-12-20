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

namespace FirstTask
{
    public partial class Form1 : Form
    {
        bool ide => bit29.Checked;
        bool rtr => RTR.Checked;

        int id => int.Parse(ID.Text, NumberStyles.HexNumber);
        byte dlc => Convert.ToByte(DLC.Text);
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

        CAN_Message message;

        private Config config;

        private string[] ports => SerialPort.GetPortNames();
        private TextBox[] dataBoxes;
        public Form1()
        {
            InitializeComponent();
            GetAllPorst();
            config = JsonSerializer.Deserialize<Config>(File.OpenRead("config.json"));
            dataBoxes = new TextBox[] { Data1, Data2, Data3, Data4, Data5, Data6, Data7, Data8 };
        }
        private void AddMessage(ListView listView)
        {
            //ListViewItem message = new ListViewItem(msgData["CH"]);
            //message.SubItems.Add(msgData["Флаги"]);
            //message.SubItems.Add(msgData["ID"]);
            //message.SubItems.Add(msgData["DLC"]);
            //message.SubItems.Add(msgData["Данные"]);
            //message.SubItems.Add(msgData["Период"]);
            //message.SubItems.Add(msgData["Счетчик"]);
            //message.SubItems.Add(msgData["ASCII"]);
            //message.SubItems.Add(msgData["Коментарий"]);
            //listView.Items.Add(message);
        }
        private void GetAllPorst()
        {
            COMs.Items.Clear();
            COMs.Items.AddRange(ports);

        }
        private void SetMessageButton_click(object sender, EventArgs e)
        {
            message = new CAN_Message(id,ide,rtr,dlc, data);
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
