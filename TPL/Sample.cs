using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL
{
    class Sample
    {
        int counter;

        public void DoTask()
        {
            counter++;
            Console.WriteLine("Counter before is " + counter);
            var T=Task.Factory.StartNew(() => DoAnotherTask());
            //T.Wait();
            Console.WriteLine("Counter after is " + counter); // 1 without wait, 2 with wait

        }

        public void DoAnotherTask()
        {
            counter++;
        }
    }
}
