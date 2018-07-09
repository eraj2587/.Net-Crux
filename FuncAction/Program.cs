using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncAction
{
    //https://msdn.microsoft.com/en-us/library/bb549151(v=vs.110).aspx
    class Program
    {
        /*
       Func<string, string> selector = 
           (x) => 
       {
           return x.ToUpper();
       };
       */

        static Func<string, string> selector = x => x.ToUpper();
        
        static void Main(string[] args)
        {
           var line= Console.ReadLine();
            Console.WriteLine(selector(line));
            Console.ReadKey();

        }
       
            
  }
}
