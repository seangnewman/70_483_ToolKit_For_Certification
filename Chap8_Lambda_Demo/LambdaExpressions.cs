using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap8_delegate_Demo
{
    static class LambdaExpressions
    {
        

        public static void WriteToConsoleForward(string stringToWrite)
        {
            Console.WriteLine("This is my string: {0}", stringToWrite);
        }

        public static void WriteToConsoleBackward(string stringToWrite)
        {

            char[] string2Char = stringToWrite.ToCharArray();

            Array.Reverse(string2Char);

            Console.WriteLine("This is my string: {0}", new string(string2Char));
        }
    }
}
