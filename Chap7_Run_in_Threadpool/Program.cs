using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace 
Run_in_Threadpool
{
    class Program
    {
        static void Main(string[] args)
        {
            //We are using Stopwatch to time the code
            Stopwatch sw = Stopwatch.StartNew();

            //Here we call different methods
            //For different ways of ways of running our application
            RunWithThreadPool();

            //Print the time it took to run the application
            Console.WriteLine("We're done in {0} ms!", sw.ElapsedMilliseconds);
            if (Debugger.IsAttached)
            {
                Console.Write("Press any key to continue...");
                Console.ReadKey(true);
            }

        }

        static void RunWithThreadPool()
        {
            double result = 0d;
            //Create a work item to read from I/O

            //QueueUserWorkItem places work item on queue
            ThreadPool.QueueUserWorkItem((x) => {
                result += ReadDataFromIO();   
            });

            //Save the result from the calculation into another variable
            double result2 = DoIntensiveCalculations();
            //Wait for the thread to finish

            //TODO : We will need a way to indicate
            //when the thread pool thread finished the execution

            //calculate the end result
            result += result2;

            //Print the result
            Console.WriteLine("The result is {0}", result);

        }
        static double ReadDataFromIO()
        {
            // We are simulating an I/O by putting the current thread to sleep

            //Note that if sleep time exceeds the time DoIntensiveCalculation runs, an incorrect value is returned
            // because there is no mechanism in ThreadPools to signal when the other thread from pool has finished
            Thread.Sleep(200);
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
