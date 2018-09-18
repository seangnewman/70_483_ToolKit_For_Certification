using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap4_IsInfinity
{
    class Program
    {
        static void Main(string[] args)
        {
            double big = -1E40;
            float small = (float)big;
            if (float.IsInfinity(small))
            {
                throw new OverflowException();
            }

        }
    }
}
