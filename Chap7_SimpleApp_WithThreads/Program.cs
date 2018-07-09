using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;


namespace Chap7_SimpleApp_WithThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            //We are using Stopwatch to time the code
            Stopwatch sw = Stopwatch.StartNew();

            //Here we call different methods
            //For different ways of ways of running our application
            RunWithThreads();

            //Print the time it took to run the application
            Console.WriteLine("We're done in {0} ms!", sw.ElapsedMilliseconds);
            if (Debugger.IsAttached)
            {
                Console.Write("Press any key to continue...");
                Console.ReadKey(true);
            }
        }

        

        static void RunWithThreads()
        {
            double result = 0d;

            //Create the thread to read from I/O
            var thread = new Thread(() => result = ReadDataFromIO());

            //start the thread
            thread.Start();

            //Save the result of the calculation into another variable
            double result2 = DoIntensiveCalculations();

            // Wait for the thread to finish
            thread.Join();

            // Calculate the end result
            result += result2;

            //Print the result
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

            for (int i = 1; i < maxValue; i++)
            {
                result /= i;
                //Console.WriteLine("The result is {0}", i);
            }
            return result + 10d;
        }
    }
}
