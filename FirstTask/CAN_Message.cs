using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FirstTask
{
    class CAN_Message: ListViewItem
    {
        string _channel;
        int _StdId;
        int _ExtId;
        bool _IDE;
        bool _RTR;
        byte _DLC;
        int[] _Data;
        string _data_str = "";
        string _comment;

        public CAN_Message(string message)
        {
                int i = 1;
                if (message[i] == '0')
                {
                    _IDE = false;
                    _StdId = Convert.ToInt32(message.Substring(2, 11),2);
                    i += 12;
                }
                else
                {
                    _IDE = true;
                    _ExtId = Convert.ToInt32(message.Substring(2, 29),2);
                    i += 30;
                }

                if (message[i] == '0')
                    _RTR = false;
                else
                    _RTR = true;
                i++;

                _DLC = Convert.ToByte(message.Substring(i, 4),2);
                i += 4;

                _Data = new int[_DLC];


                for (int d =0; d < _DLC; d++)
                {
                    _Data[d] = Convert.ToInt32(message.Substring(i, 4),2);
                    i += 4;
                }


        }

        public CAN_Message(string channel,int id, bool ide, bool rtr, byte dlc, int[] data,string Comment) 
        {
            _channel = channel;
            _IDE = ide;
            if (ide)
                _ExtId = id;
            else
                _StdId = id;
            _RTR = rtr;
            _DLC = dlc;
            _Data = new int[_DLC];
            Array.Copy(data, _Data, _DLC);
            _comment = Comment;
            UpdateSubItems();
        }

        private void UpdateSubItems()
        {
            foreach (int i in _Data)
            {
                _data_str += i.ToString("X").PadLeft(2, '0') + " ";
            }
            // Очищаем существующие подэлементы
            SubItems.Clear();
            Text = _channel;
            // Добавляем подэлементы согласно вашей логике
            SubItems.Add("COM");

            if (_IDE)
                SubItems.Add(_ExtId.ToString("X"));
            else
                SubItems.Add(_StdId.ToString("X"));

            SubItems.Add(_DLC.ToString());

            SubItems.Add(_data_str);
            SubItems.Add(_comment);

        }
        public string To_Binary()
        {
            string binaryStr;
            binaryStr = " 1 ";
            if (_IDE)
                binaryStr += " 1 " + Convert.ToString(_ExtId, 2).PadLeft(29, '0');
            else
                binaryStr += " 0 " + Convert.ToString(_StdId & 0x7FF, 2).PadLeft(11, '0');

            if (_RTR)
                binaryStr += " 1 ";
            else
                binaryStr += " 0 ";

            binaryStr += Convert.ToString(_DLC, 2).PadLeft(4, '0');
            binaryStr += " ";

            foreach (int i in _Data) 
            {
                binaryStr += Convert.ToString(i, 2).PadLeft(4, '0');
                binaryStr += " ";
            }

            return binaryStr;
        }
    }
}
