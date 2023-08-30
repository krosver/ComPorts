using System.Windows.Forms;
using System.IO.Ports;
using static FirstTask.COM;
using System;

namespace FirstTask
{
    public partial class Form1 : Form
    {
        private COM com;
        private Timer timer;
        public Form1()
        {
            InitializeComponent();
            GetAllPorst();
            onDataReceived += DataReceived;
        }
        private void GetAllPorst()
        {
            if (SerialPort.GetPortNames().Length != 0)
            {
                comboBox_COMs.Items.Clear();
                foreach (var port in SerialPort.GetPortNames())
                {
                    comboBox_COMs.Items.Add(port);
                }
            }
        }
        private void comboBox_COMs_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var portName = comboBox_COMs.Text;
            try
            {
                if (com == null)
                    com = new COM(portName);
                else
                    com.NewComPort(portName);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DataReceived(string comMsg)
        {
            try
            {
                textBox_MsgGet.Text = comMsg;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button_setMsg_Click(object sender, System.EventArgs e)
        {
            try
            {
                com.SetMsg(textBox_MsgSet.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
