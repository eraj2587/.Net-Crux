using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Swap numbers
         /*   while (true)
            {
                Console.WriteLine("Read A");
                var a = Console.ReadLine();
                Console.WriteLine("Read B");
                var b = Console.ReadLine();
                SwapNumbers numbers = new SwapNumbers();
                numbers.GetSwap(Convert.ToInt32(a), Convert.ToInt32(b));
                Console.WriteLine("\nPress any key to continue and Esc to exit!");
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
            */

            //Triangle
            while (true)
            {
                Triangle t = new Triangle();
                Console.WriteLine("Enter number of lines for triangle");
                var num = Console.ReadLine();
                Console.ForegroundColor=ConsoleColor.Green;
                t.Draw(Convert.ToInt32(num));
                Console.ForegroundColor = ConsoleColor.White;
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
            
        }
    }
}
