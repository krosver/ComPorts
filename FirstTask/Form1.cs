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
        CanMsg msg = new CanMsg();
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
        private string[] ports => SerialPort.GetPortNames();

        private bool nonNumberEntered;
        private TextBox[] dataBoxes;
        public Form1()
        {
            InitializeComponent();
            GetAllPorst();
            config = JsonSerializer.Deserialize<Config>(File.OpenRead("config.json"));
            dataBoxes = new TextBox[] { Data8, Data7, Data6, Data5, Data4, Data3, Data2, Data1 };
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
            COMs.Items.Clear();
            trigger_com.Items.Clear();

            COMs.Items.AddRange(ports);

            trigger_com.Items.Add("Все");
            trigger_com.Items.AddRange(ports);
        }
        private void SetMessageButton_click(object sender, EventArgs e)
        {
            //msg.CH = COMs.Text;
            //msg.Flags = "COM";
            msg.ID = int.Parse(ID.Text);
            msg.DLC = int.Parse(DLC.Text); 
            msg.Data = new int[]{
                int.Parse(Data8.Text,NumberStyles.HexNumber), int.Parse(Data7.Text,NumberStyles.HexNumber), int.Parse(Data6.Text,NumberStyles.HexNumber),
                int.Parse(Data5.Text,NumberStyles.HexNumber), int.Parse(Data4.Text,NumberStyles.HexNumber), int.Parse(Data3.Text,NumberStyles.HexNumber),
                int.Parse(Data2.Text,NumberStyles.HexNumber), int.Parse(Data1.Text,NumberStyles.HexNumber)};
            //msg.Comment = Comment.Text;
            msg.RTR =Convert.ToInt32(RTR.Checked);
            msg.Bit29 = Convert.ToInt32(bit29.Checked);
            MessageBox.Show(msg.ToString());
            CRC();
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
                if (!isInt)
                {
                    MessageBox.Show("Неверный формат числа");
                    tb.Text = "00";
                }
            }
        }

        private void CRC()
        {
            double sum = Math.Pow(msg.Data[0], 15) + Math.Pow(msg.Data[1], 14) + Math.Pow(msg.Data[2], 10) +
                Math.Pow(msg.Data[3], 8) + Math.Pow(msg.Data[4], 7) + Math.Pow(msg.Data[5], 4) +
                Math.Pow(msg.Data[6], 3) + Math.Pow(msg.Data[7], 0);
            long l = (long)sum;
            var hexstr = l.ToString("X8");
            var b = 1;
        }

        private void bit29_CheckedChanged(object sender, EventArgs e)
        {
            if (bit29.Checked)
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

        private void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, является ли введенный символ цифрой
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Если символ не цифра и не управляющий символ, отменяем ввод
                e.Handled = true;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
