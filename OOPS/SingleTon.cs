using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
   public class SingleTon
   {
       public static SingleTon _instace;

       private SingleTon()
       {
       }

       public static SingleTon GetInstace()
       {
           if (_instace == null)
           {
               _instace=new SingleTon();
           }

           return _instace;
       }

   }
}
