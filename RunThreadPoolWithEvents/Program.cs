using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chap7_RunThreadPoolWithEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            //We are using Stopwatch to time the code
            Stopwatch sw = Stopwatch.StartNew();

            //Here we call different methods
            //For different ways of ways of running our application
            RunInThreadPoolWithEvents();

            //Print the time it took to run the application
            Console.WriteLine("We're done in {0} ms!", sw.ElapsedMilliseconds);
            if (Debugger.IsAttached)
            {
                Console.Write("Press any key to continue...");
                Console.ReadKey(true);
            }

        }

        static void RunInThreadPoolWithEvents()
        {
            double result = 0d;

            //We use this event to signal when the thread is done executing
            EventWaitHandle calculationDone =
                new EventWaitHandle(false, EventResetMode.ManualReset);   //Non signaled specified by false



            //Create a work item to read from I/O

            //QueueUserWorkItem places work item on queue
            ThreadPool.QueueUserWorkItem((x) => {
                result += ReadDataFromIO();
                calculationDone.Set();                                //Signal that the work has completed
            });

            //Save the result from the calculation into another variable
            double result2 = DoIntensiveCalculations();
            //Wait for the thread to finish

            //TODO : We will need a way to indicate
            //when the thread pool thread finished the execution
            calculationDone.WaitOne();   //Wait for signal to be returned

            //calculate the end result
            result += result2;

            //Print the result
            Console.WriteLine("The result is {0}", result);

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


 
