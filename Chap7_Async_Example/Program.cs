using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chap7_Async_Example
{
    class Program
    {
        const int NUMBER_OF_ITERATIONS = 32;

        static void Main(string[] args)
        {
            //We are using Stopwatch to time the code
            Stopwatch sw = Stopwatch.StartNew();

        
            ReadDataFromIOAsync();

            //Print the time it took to run the application
            Console.WriteLine("We're done in {0}ms!", sw.ElapsedMilliseconds);
            Console.ReadKey();


        }

        

        static double ReadDataFromIO()
        {
            // We are simulating an I/O by putting the current thread to sleep
            Thread.Sleep(50);
            return 10d;

        }

        public static Task<double> ReadDataFromIOAsync()
        {
            return Task.Run(new Func<double> (ReadDataFromIO));
        }

        static double DoIntensiveCalculations()
        {
            // We are simulating intensive calculations
            // by performing nonsense divisions
            double result = 10000d;
            var maxValue = Int32.MaxValue >> 4;

            for (int i = 1; i < maxValue; i++)
            {
                if (i % 2 == 0)
                {
                    result /= i;
                }
                else
                {
                    result *= i;
                }

                //Console.WriteLine("The result is {0}", i);
            }
            return result + 10d;
        }



    }
}
