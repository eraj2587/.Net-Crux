using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Keywords
{
    static class YieldSample
    {
         static int[] myints = new int[] { 6, 2, 9, 4, 5 };

        public static void Consumer()
        {
            //avoid making another variable to store filtered records
            Console.WriteLine("Avoid second variable");
         GetYieldList().ToList().ForEach(x=>Console.WriteLine(x));

            //To persist state of caller
         Console.WriteLine("Persists state of caller");
         GetYieldList2().ToList().ForEach(x => Console.WriteLine(x));


        }

        public static IEnumerable<int> GetYieldList2()
        {
            int counter = 0;

            foreach (int i in myints)
            {
                counter += i;
                yield return counter;
            }
        } 

        /// <summary>
        /// Customized iteration through a collection without creating a temporary collection.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<int> GetYieldList()
        {
            foreach (int i in myints)
            {
                if (i > 2)
                    yield return i;
            }
        }
    }
}
