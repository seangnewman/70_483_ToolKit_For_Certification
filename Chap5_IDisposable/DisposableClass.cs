using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5_IDisposable
{
    class DisposableClass : IDisposable
    {

        // A name to keep track of the object
        public string Name = String.Empty;

        // Free managed and unmanaged resources
        public void Dispose()
        {
            FreeResources(true);
        }

        // Destructor to clean unmanaged resources
        ~DisposableClass()
        {
            FreeResources(true);
        }

        // Free resources

        private void FreeResources(bool freeManagedResources)
        {
            Console.WriteLine("{0}: FreeResources", Name);

            if (!ResourcesAreFreed)
            {
                // Dispose of managed resources if appropriate
                if (freeManagedResources)
                {
                    // Dispose of managed resources
                    Console.WriteLine("{0} : Dispose of managed resources.", Name);
                }

                // Dispose of unmanaged resources here
                Console.WriteLine("{0} Dispose of unmanaged resources.", Name);

                // Remember that we have disposed of resources
                ResourcesAreFreed = true;

                // We don't need the destructor because our resources are already freed
                GC.SuppressFinalize(this);
            }
        }

        //Keep track of whether resources are already freed
        private bool ResourcesAreFreed = false;

        

    }
}
