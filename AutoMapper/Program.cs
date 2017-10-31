using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new ABC {Id = 1, Name = "test"};

            //CREATES DIFFERENT OBJECTS - Copy all properties to other object

            Mapper.CreateMap<ABC, ABC>();
            ABC b = Mapper.Map<ABC>(a);

            Console.WriteLine("Hashcode for a is : "+a.GetHashCode());
            Console.WriteLine("Hashcode for b is : " + b.GetHashCode());

            //TWO ALIASES OF SAME OBJECT
            ABC c = a;
            c.Name = "test A";
            Console.WriteLine("Hashcode for c is : " + c.GetHashCode());
            Console.WriteLine("Name is : "+c.Name);

            //Shallow copy and deep copy

            ABC shallowObj = a.ShallowCopy();
            Console.WriteLine("Hashcode for shallowObj is : " + shallowObj.GetHashCode());

            a.ChildABC=new ABC { Id=123 };
            ABC deepObj = a.DeepCopy();
            Console.WriteLine("Hashcode for deepObj is : " + deepObj.GetHashCode());

            Console.ReadKey();
        }
    }

    class ABC
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ABC ChildABC;

        public ABC ShallowCopy()
        {
            return (ABC) this.MemberwiseClone();
        }

        public ABC DeepCopy()
        {
            var obj= (ABC)this.MemberwiseClone(); //copy all non static value type fields
            obj.ChildABC = (ABC)this.ChildABC.MemberwiseClone();  // copy all non static fields of child object
            return obj;
        }

    }
}
