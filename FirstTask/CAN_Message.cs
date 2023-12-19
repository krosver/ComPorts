using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    struct CAN_Message
    {
        public Int32 StdId;
        public Int32 ExtId;
        public bool IDE;
        public bool RTR;
        public byte DLC;
        public byte[] Data;
    }
}
