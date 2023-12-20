using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class CAN_Message
    {
        public Int32 StdId;
        public Int32 ExtId;
        public bool IDE;
        public bool RTR;
        public byte DLC;
        public int[] Data;

        public CAN_Message(int id, bool ide, bool rtr, byte dlc, int[] data) 
        {
            IDE = ide;
            if (ide)
                ExtId = id;
            else
                StdId = id;
            RTR = rtr;
            DLC = dlc;
            Data = new int[DLC];
            Array.Copy(data, Data, DLC);
        }
    }
}
