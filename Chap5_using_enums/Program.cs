using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5_using_enums
{
    class Program
    {
        enum Months { Jan = 1, Feb, March, April, May, June, July, Aug, Sep, Oct, Nov, Dec };

        static void Main(string[] args)
        {
            String name = Enum.GetName(typeof(Months), 8);
            Console.WriteLine("The 8th month in the enumeration is {0}", name);

            Console.WriteLine("The underlying values of the Months enum");

            foreach (int month in Enum.GetValues(typeof(Months)))
            {
                Console.WriteLine(month);
            }

            foreach (string month in Enum.GetNames(typeof(Months)))
            {
                Console.WriteLine(month);
            }

        }
    }
}
