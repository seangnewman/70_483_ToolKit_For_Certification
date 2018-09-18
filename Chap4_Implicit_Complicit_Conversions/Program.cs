using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap4_Implicit_Complicit_Conversions
{
    class Program
    {
        static void Main(string[] args)
        {

            //Narrowing conversion so explicit conversion is required
            double value1 = 10;
            float value2 = (float)value1;

            //Widening conversion so implicit conversion is allowed
            int value3 = 10;
            long value4 = value3;

            Console.WriteLine("Explicit conversion of value1 {0} results in value2 {1}", value1, value2);
            Console.WriteLine("Implict conversion of value3 {0} results in value4 {1}", value3, value4);
        }
    }
}
