using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {
        static int  m_count = 0;

        static void Main(string[] args)
        {
            ///* LOCK and MONITOR
            SimpleThread th = new SimpleThread();
            th.CallThread();
           // */

            /*
            MutexDemo p = new MutexDemo();
            p.Example();
            Console.ReadKey();
            */
        }

        
    }
}
