using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap4_Checked
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                int big = 100000000;
                short small = (short)big;
                 
            }

        }
    }
}
