using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL
{
    class Program
    {
        static void Main(string[] args)
        {

            //var t= Task.Run(() => { DoTask();});
            /* //var tt = Task.Factory.StartNew(() => { DoTask(); });  both are same but this one with more options
             Task.WaitAll(t); //wait for task
             */

            // Task.Run(async () => await DoTaskAsync()).ContinueWith(task => DoTask());//DoTask will run after DoTaskAsync
            //Thread does not wait instead 

            //Sample s = new Sample();
            //s.DoTask();

            Loops l = new Loops();
            l.DoTask();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }

        public static void DoTask()
        {
            Console.WriteLine("Task1 Started");
            Thread.Sleep(5000);
            Console.WriteLine("Done with task1");
        }

        public static Task DoTaskAsync()
        {
            Console.WriteLine("Task2 Started");
            Thread.Sleep(3000);
            Console.WriteLine("Done with task2");
            return Task.FromResult(0);
        }
    }
}
