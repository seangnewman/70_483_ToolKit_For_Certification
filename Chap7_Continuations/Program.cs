using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap7_Continuations
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Step1, Step2 and Step 3 are independent
            //May be run in any order
            Parallel.Invoke(Step1, Step2, Step3);
            Console.WriteLine();

            //Step 2 Step 1 and Step 2 are independent
            // Step 3 is dependent upon completion of step 1
            Task step1Task = Task.Run( () => Step1());
            Task step2Task = Task.Run(() => Step2());
            Task step3Task = step1Task.ContinueWith((previousTask) => Step3());
            Task.WaitAll(step2Task, step3Task);
            Console.WriteLine();

            //Step 1 and 2 are independent 
            //Step 3 is dependent upon both step 1 and step 2 completing
            Task step1Task1 = Task.Run(() => Step1());
            Task step2Task2 = Task.Run(() => Step2());
            Task step3Task3 = Task.Factory.ContinueWhenAll(
                new Task[] {step1Task1, step2Task2}, (previousTasks) => Step3()
                );


            step3Task3.Wait();
            Console.WriteLine();

            //Step 1 and 2 are independent 
            //Step 3 is dependent upon either step 1 and step 2 completing
            Task step1Task4 = Task.Run(() => Step1());
            Task step2Task5 = Task.Run(() => Step2());
            Task step3Task6 = Task.Factory.ContinueWhenAny(
                new Task[] { step1Task4, step2Task5 }, (previousTasks) => Step3()
                );


            step3Task6.Wait();
            Console.WriteLine();

            Console.ReadKey();
        }

        static void Step1()
        {
            Console.WriteLine("Step 1");
        }

        static void Step2()
        {
            Console.WriteLine("Step 2");
        }
        static void Step3()
        {
            Console.WriteLine("Step 3");
        }
    }
}
