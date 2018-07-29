using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BarrierSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = 26;

            Barrier barrier = new Barrier(participants + 1,         // Add one for main thread
                    b =>
                    {
                        //This method is only called when all the participants arrived
                        Console.WriteLine("{0} Participants are at rendezvous point {1}.",
                            b.ParticipantCount - 1,     //We subtract main thread)
                            b.CurrentPhaseNumber);
                    });

            for(int i = 0; i < participants; i++)
            {
                var localCopy = i;
                Task.Run(() => {
                    Console.WriteLine("Task {0} left point A!", localCopy);
                    Thread.Sleep(1000 * localCopy + 1);     //Simulate work
                    if(localCopy % 2 == 0)
                    {
                        Console.WriteLine("Task {0} arrived at Point B!", localCopy);
                        barrier.SignalAndWait();
                    }
                    else
                    {
                        Console.WriteLine("Task {0} changed it's mind and went back!", localCopy);
                        barrier.RemoveParticipant();
                        return;
                    }

                    Thread.Sleep(1000 * (participants - localCopy));            // Simulate additional work
                    Console.WriteLine("Task {0} arrived at point C!", localCopy);
                    barrier.SignalAndWait();

                });
            }
            Console.WriteLine("Main thread is waiting for {0} tasks", barrier.ParticipantCount - 1);
            barrier.SignalAndWait();    // waiting at the first phase
            barrier.SignalAndWait();    // waiting at the second phase
            Console.WriteLine("Main thread is done");

            Console.ReadKey();
        }
    }
}
