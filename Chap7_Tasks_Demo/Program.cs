using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chap7_Tasks_Demo
{
    class Program
    {
        const int NUMBER_OF_ITERATIONS = 32;

        static void Main(string[] args)
        {
            //We are using Stopwatch to time the code
            Stopwatch sw = Stopwatch.StartNew();

            //Run the method
            //RunSequential();
            RunTasksCorrected();

            //Print the time it took to run the application
            Console.WriteLine("We're done in {0}ms!", sw.ElapsedMilliseconds);
            Console.ReadKey();
            
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

        static void RunSequential()
        {
            double result = 0d;

            //Here we call same method several times
            for(int i=0; i < NUMBER_OF_ITERATIONS; i++)
            {
                result += DoIntensiveCalculations();
            }

            //Print the result
            Console.WriteLine("The result is {0}", result);
        }

        static void RunTasks()
        {
            double result = 0d;

            Task[] tasks = new Task[NUMBER_OF_ITERATIONS];

            //We create ibe task per iteration
            for(int i=0; i < NUMBER_OF_ITERATIONS; i++)
            {
                tasks[i] = Task.Run(() => {
                    result += DoIntensiveCalculations();
                });
            }

            //Print the result
            Console.WriteLine("The result is {0}", result);
        }

        static void RunTasksCorrected()
        {
            double result = 0d;

            Task<double>[] tasks = new Task<double>[NUMBER_OF_ITERATIONS];

            //We create ibe task per iteration
            for (int i = 0; i < NUMBER_OF_ITERATIONS; i++)
            {
                tasks[i] = Task.Run(() => 
                    DoIntensiveCalculations()
                    );
            }
            //Wait for all tasks to finish
            Task.WaitAll(tasks);
            //Collect the results
            foreach(var task in tasks)
            {
                result += task.Result;
            }
            //Print the result
            Console.WriteLine("The result is {0}", result);
        }


        static double ReadDataFromIO()
        {
            // We are simulating an I/O by putting the current thread to sleep
            Thread.Sleep(50);
            return 10d;

        }

        static double DoIntensiveCalculations()
        {
            // We are simulating intensive calculations
            // by performing nonsense divisions
            double result = 10000d;
            var maxValue = Int32.MaxValue >> 4;

            for (int i = 1; i < maxValue; i++)
            {
                if( i % 2 == 0)
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
