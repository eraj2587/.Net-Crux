using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollection
{
    class Employee : IDisposable
    {
        public int Id { get; set; }
        public int Name { get; set; }

        public void Dispose()
        {
        }
    }
}
