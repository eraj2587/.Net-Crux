using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class CallByValue
    {
        public void GetValues(int x,ref int y,out int z)
        {
            x = 30;
            y = 40;
            z = 50;
         }

        public void GetRefVales(Test x, ref Test y, out Test z)
        {
            z=new Test();

            x = new Test() {a = 30};
            y = new Test() { a = 40 }; //orignal reference

           // x.a = 30; //copy of reference
            //y.a = 40;
            z.a = 50;
        }
    }

    public class Test
    {
        public int a;
    }


}
