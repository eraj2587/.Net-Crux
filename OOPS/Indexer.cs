using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class A
    {
        public int[] a = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9};

        public int this[int n]
        {
            get { return a[n]*2; }
            set { a[n] = value; }
        }

        public void Example()
        {
            DataSet set = new DataSet();
            var table=set.Tables["test"];
        }


}
}
