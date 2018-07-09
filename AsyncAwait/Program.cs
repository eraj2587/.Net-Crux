using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In Main");
            Console.WriteLine($"This thread is {(Thread.CurrentThread.IsBackground ? "Background" : "Foreground")}" +
                $" with ID {Thread.CurrentThread.ManagedThreadId}");
            //------------------------------------------------------------------------------
            //CallAsync();
            /*Run on the same thread and callee stops for called method
            ****OUTPUT****
                In Main
                This thread is Foreground with ID 1
                Call Method
                This thread is Foreground with ID 1
                Existing Main
             */
            //------------------------------------------------------------------------------

            Task.Run(async () =>
            {
                await CallAsync();
            });
            /*Run on different thread and callee wait for called method but contiue its execution 
             and return its state when called method completed
           ****OUTPUT****
                In Main
                This thread is Foreground with ID 1
                Existing Main
                Press any key to exit...
                Call Method
                This thread is Background with ID 3
           */


            Console.WriteLine("Existing Main");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public static async Task CallAsync()
        {
            Thread.Sleep(5000);
            await Console.Out.WriteLineAsync("Call Method");
            Console.WriteLine($"This thread is {(Thread.CurrentThread.IsBackground ? "Background" : "Foreground")}" +
                $" with ID {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
