using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndFunc
{
    class EventUsage
    {
        public delegate void MyDelegate();

        private MyDelegate _myDelegate;

        public event MyDelegate MyEvent
        {
            add { _myDelegate += value; }
            remove { if (value != null) _myDelegate -= value; }
        }

        public void RaiseMyEvent() { _myDelegate(); }

        public static void Cat()
        {
            Console.WriteLine("Cat");
        }

        public static void Dog()
        {
            Console.WriteLine("Dog");
        }

        public static void Mouse()
        {
            Console.WriteLine("Mouse");
        }
    }
}
