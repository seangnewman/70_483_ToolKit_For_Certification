using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chap7_BarriersWithCancellations
{
    class Program
    {
        static void Main(string[] args)
        { 
            var participants = 20;

            // We create a CancellationTokenSource to be able to initiate the cancellation
            var tokenSource = new CancellationTokenSource();


            var barrier = new Barrier(participants ,         // Add one for main thread
                b =>
                {
                        //This method is only called when all the participants arrived
                        Console.WriteLine("{0} Participants are at rendezvous point {1}.",
                        b.ParticipantCount ,     //We subtract main thread)
                        b.CurrentPhaseNumber);
                });

            for(int i = 0; i<participants; i++)
            {
                var localCopy = i;
                Task.Run(() => {
                    Console.WriteLine("Task {0} left Point A!", localCopy);
                    Thread.Sleep(1000 * localCopy + 1);     //Simulate work
                    if(localCopy % 2 == 0)
                    {
                        Console.WriteLine("Task {0} arrived at Point B!", localCopy);
                        barrier.SignalAndWait(tokenSource.Token);
                    }
                    else
                    {
                        Console.WriteLine("Task {0} changed it's mind and went back!", localCopy);
                        barrier.RemoveParticipant();
                        return;
                    }

                    Thread.Sleep(1000 * (localCopy + 1) );            // Simulate additional work
                    Console.WriteLine("Task {0} arrived at point C!", localCopy);
                    barrier.SignalAndWait(tokenSource.Token);

                });
            }
            Console.WriteLine("Main thread is waiting for {0} tasks", barrier.ParticipantCount - 1);
            Console.WriteLine("Press enter to cancel");
            Console.ReadLine();

            if(barrier.CurrentPhaseNumber < 2)
            {
                tokenSource.Cancel();
                Console.WriteLine("Operation Cancelled");
            }
            else
            {
                Console.WriteLine("To late to cancel operation!");
            }
         
            Console.WriteLine("Main thread is done");

            Console.ReadKey();
        }
    }
}
