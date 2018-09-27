using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap8_anonymous_Demo
{
    class Program
    {
        delegate void MyFirstDelegate(string s);

        static void Main(string[] args)
        {
            MyFirstDelegate forward = delegate (string s2)
            {
                Console.WriteLine("This is my string: {0}", s2);
            };

            forward("No Red October this year!");
        }
    }
}
