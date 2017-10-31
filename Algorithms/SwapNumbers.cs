using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class SwapNumbers
    {
        public void GetSwap(int a, int b)
        {
            Console.WriteLine("Before Swap value of A is :{0} and B is : {1}", a, b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("After Swap value of A is :{0} and B is : {1}",a,b);
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }
    }
}
