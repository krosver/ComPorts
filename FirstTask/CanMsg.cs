using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class CanMsg
    {
        public int ID { get; set; }
        public int DLC { get; set; }
        public int[] Data { get; set; }
        public int Bit29 { get; set; }
        public int RTR { get; set; }
        public int Value { get; set; }
        public string Comment { get; set; }
        public override string ToString()
        {
            string str = string.Empty;
            str += Convert.ToString(ID, 2);
            str += "    ";
            str += Convert.ToString(RTR, 2);
            str += "    ";
            str += Convert.ToString(Bit29, 2);
            str += "    ";
            str += Convert.ToString(DLC, 2);
            str += "    ";
            foreach (var b in Data)
                str += Convert.ToString(b, 2).PadLeft(8, '0') + " ";
            return str;
        }


    }
}
