using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
   public class Parent
    {
        public int a = 10;
        protected int b = 20;

        public int calc(int x, int y)
        {
            return x + y; //addtion
        }

        public virtual int calc1(int x, int y)
        {
            return x + y; //addtion
        }

        public virtual int calc2(int x, int y)
        {
            return x + y; //addtion
        }
    }

   public class Child:Parent
    {
        int a;

        private int b;

        public int calc(int x, int y)
        {
            return x * y; //multiplication
        }

        public override int calc1(int x, int y)
        {
            return x * y; //multiplication
        }

        public new int calc2(int x, int y)
        {
            return x * y; //multiplication
        }

    }


}
