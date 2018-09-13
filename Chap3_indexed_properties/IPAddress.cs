using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3_indexed_properties
{
    class IPAddress
    {
        private int[] ip;

        public int[] IP
        {
            get { return ip; }
            set { ip = value; }
        }

        public int this[int index]
        {
            get
            {
                return IP[index];
            }
            set
            {
                if (value == 0 || value == 1)
                {
                    IP[index] = value;

                }
                else
                {
                    throw new Exception("Invalid value");
                }
            }
        }

    }
}
