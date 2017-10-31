using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    /// <summary>
    /// Mutex handles thread saftey between more than one process who wants to take control over the resource 
    /// </summary>
    internal class MutexDemo
    {
        private static Mutex mutex = new Mutex();

        public void Example()
        {
            //Create mumber of thread to explain muiltiple thread example  
            for (int i = 0; i < 4; i++)
            {
                Thread t = new Thread(MutexCall);
                t.Name = string.Format("Thread {0} :", i + 1);
                t.Start();
            }
        }

        //Method to implement syncronization using Mutex  
        private static void MutexCall()
        {
            try
            {
                //Blocks the current thread until the current WaitHandle receives a signal.   
                mutex.WaitOne(); // Wait until it is safe to enter.  
                Console.WriteLine("{0} has entered in the Domain", Thread.CurrentThread.Name);
                Thread.Sleep(1000); // Wait until it is safe to enter.  
                Console.WriteLine("{0} is leaving the Domain\r\n", Thread.CurrentThread.Name);
            }
            finally
            {
                //ReleaseMutex unblock other threads that are trying to gain ownership of the mutex.  
                mutex.ReleaseMutex();
            }
        }
    }
}

