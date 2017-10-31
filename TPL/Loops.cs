using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL
{
    class Loops
    {
        int counter;

        public void DoTask()
        {
            //Parallel.For(0, 10000, n =>
            //{
            //    counter = n;
            //    Console.WriteLine(counter);
            //});

            //for (int i = 0; i < 10000; i++)
            //{
            //    counter = i;
            //    Console.WriteLine(counter);
            //};

            for (int i = 0; i < 10000; i++)
            {
                Task.Factory.StartNew(() => {
                    Console.WriteLine(i);
                });
                
            };

        }

    }
}
