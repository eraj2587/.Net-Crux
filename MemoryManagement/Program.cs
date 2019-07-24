using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = "test";
            var b = "test";

            if (a.GetHashCode().Equals(b.GetHashCode()))
            {
                Console.WriteLine("both are same");
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
