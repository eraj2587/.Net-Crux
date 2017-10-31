using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            #region CallByRef
            //TODO:  CALL BY VALUE AND CALL BY REFERENCE

            /*  
            CallByValue cbv = new CallByValue();

            int a = 1;
            int b = 2;
            int c = 3;
            cbv.GetValues(a, ref b, out c);
            Console.WriteLine(String.Format("a:{0}\nb:{1}\nc:{2}", a, b, c));

            Test t1 = new Test() { a = 1 };
            Test t2 = new Test() { a = 2 };
            Test t3 = new Test() { a = 3 };

            cbv.GetRefVales(t1, ref t2, out t3);
            Console.WriteLine(String.Format("t1.a:{0}\nt2.a:{1}\nt3.a:{2}", t1.a, t2.a, t3.a));
            Console.ReadKey();
            */



            #endregion

            #region Inheritence

            // TODO:INHERITANCE

            /* Valid scenario

            Child c = new Child(); 
            Console.WriteLine(c.calc(1,2));
            Parent p = new Parent();
            Console.WriteLine(p.calc(1, 2));
            */

            /* Parent Called - Before overriding
             
             Parent p = new Parent();
             Parent c = new Child();
             Console.WriteLine("Result : "+c.calc(1, 2));//3
             Console.WriteLine("Result : "+p.calc(1, 2));//3
             */


            /* After Overriding
            Parent p=new Parent();
            Parent c = new Child();
            Console.WriteLine("Result : " + p.calc1(1, 2)); //3
            Console.WriteLine("Result : " + c.calc1(1, 2)); //2
            */

            /*Hides imeplementation with NEW keyword

            Parent p = new Parent();
            Parent c = new Child();
            Console.WriteLine("Result : " + p.calc2(1, 2)); //3
            Console.WriteLine("Result : " + c.calc2(1, 2)); //3
            */
            // Console.ReadKey();

            #endregion

            #region TRYCATCHTHROW
            //TryCatchThrow t = new TryCatchThrow();
            //t.CallThisMethod();
            #endregion

            #region Singleton

            //SingleTon s = SingleTon.GetInstace();
            //Console.WriteLine(s.GetHashCode());
            //Console.WriteLine(SingleTon._instace.GetHashCode());
            //Console.ReadKey();

            #endregion


            #region Indexer

            //A a = new A();
            //Console.WriteLine("Please enter single digit");
            //var k = Console.ReadKey();
            //Console.WriteLine(string.Format("Array element at {0} is {1}",k.KeyChar,a[k.KeyChar]));
            //Console.ReadKey();

            #endregion

            #region Using



            #endregion

        }
    }

   public struct SimpleStruct
    {
        private int xval;

        public int X
        {
            get
            {
                return xval;
            }
            set
            {
                if (value < 100)
                    xval = value;
            }
        }

        public void DisplayX()
        {
            Console.WriteLine("The stored value is: {0}", xval);
        }
    }

   

}
