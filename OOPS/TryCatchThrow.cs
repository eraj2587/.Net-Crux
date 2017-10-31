using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class TryCatchThrow
    {

        public int Get()
        {
            try
            {
                return 1;
            }
            catch (Exception)
            {
                return 2;
            }
            finally
            {
               // return 3; //can not return from finally
            }
        }


        public int CallThisMethod()
        {
            try
            {
                throw new Exception("level 1");
            }
            catch (Exception ex)
            {
               // throw new Exception("level 2"); //Does not maintain full stack trace
                throw ex; // maintains caller info in stack trace
            }
        }

       
        
    }
}
