using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace Chap7_SimpleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //We are using Stopwatch to time the code
            Stopwatch sw = Stopwatch.StartNew();

            //Here we call different methods
            //For different ways of ways of running our application
            RunSequential();

            //Print the time it took to run the application
            Console.WriteLine("We're done in {0} ms!", sw.ElapsedMilliseconds);
            if (Debugger.IsAttached)
            {
                Console.Write("Press any key to continue...");
                Console.ReadKey(true);
            }
        }

        static void RunSequential()
        {
            double result = 0d;

            // Call the function  to read data from I/O
            result += ReadDataFromIO();

            // Add the result of the second calculation
            result += DoIntensiveCalculations();

            //Print the results
            Console.WriteLine("The result is {0}", result);
        }

        static double ReadDataFromIO()
        {
            // We are simulating an I/O by putting the current thread to sleep
            Thread.Sleep(5000);
            return 10d;

        }

        static double DoIntensiveCalculations()
        {
            // We are simulating intensive calculations
            // by performing nonsense divisions
            double result = 1000000000d;
            var maxValue = Int32.MaxValue;

            for(int i=1; i < maxValue; i++)
            {
                result /= i;
                //Console.WriteLine("The result is {0}", i);
            }
            return result + 10d;
        }
    }

}
