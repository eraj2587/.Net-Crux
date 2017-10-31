using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            // DelegateUsage myDelegate = new DelegateUsage();
            // myDelegate.CallDelegate();

            //Event is just wrapper over the delegates and provide security and unintension overriden of delegates
            EventUsage myEvent = new EventUsage();
            Console.WriteLine("After subscribing to event by all delegates");
            myEvent.MyEvent += EventUsage.Cat;
            myEvent.MyEvent += EventUsage.Dog;
            myEvent.MyEvent += EventUsage.Mouse;
            myEvent.RaiseMyEvent();
            Console.WriteLine("After unsubscribing to event by dog delegate");
            myEvent.MyEvent -= EventUsage.Dog;
            myEvent.RaiseMyEvent();


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
