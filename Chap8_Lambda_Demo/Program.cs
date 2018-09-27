using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap8_delegate_Demo
{
    class Program
    {

        delegate void MyFirstDelegate(string s);


        static void Main(string[] args)
        {
            MyFirstDelegate myFirstDelegate = new MyFirstDelegate(LambdaExpressions.WriteToConsoleForward);

            myFirstDelegate("I am a Software Engineer!");

            myFirstDelegate = new MyFirstDelegate(LambdaExpressions.WriteToConsoleBackward);

            myFirstDelegate("I am a Software Engineer!");
        }
    }
}
