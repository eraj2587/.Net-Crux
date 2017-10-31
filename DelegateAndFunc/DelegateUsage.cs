using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndFunc
{
    public class DelegateUsage
    {
       public delegate int MyDelegate(int a, int b);

        public void CallDelegate()
        {
            MyDelegate addition=add;
            MyDelegate substraction = substract;

            Console.Title = "Deletegate Demo";

            Console.WriteLine("\n\n----------Singlecast delegate------------");
            addition(2, 3);
            substraction(2, 3);

            Console.WriteLine("\n\n----------Multicast delegate------------");
            MyDelegate multicast;
            multicast = add;
            multicast += substract;

            multicast(2, 3);

          

        }

        public int add(int a, int b)
        {
            Console.WriteLine("Delegate called with method add : " + a + b);
            return a + b;
        }

        public int substract(int a, int b)
        {
            Console.WriteLine("Delegate called with method substract : " + (a - b));
            return a - b;
        }

}
}
