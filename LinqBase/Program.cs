using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Basics.LinqBase;

namespace LinqBase
{
    public class Program
    {
        public static void Main(string[] args)
        {
          // LazyLoading();

            QurableAndIQuarable();

        }

        public static void QurableAndIQuarable()
        {
            using (var context = new CarContext("CarContextString"))
            {
                //  var cars = context.Cars.Include(x=>x.Tyres); //TODO: With eager loading
                var cars = context.Cars.ToList(); //TODO : Lazy loading with virtual keyword

                foreach (var car in cars)
                {
                    Console.WriteLine(car.CarId);
                    foreach (var tyre in car.Tyres)
                    {
                        Console.WriteLine(tyre.Size);
                    }
                    Console.WriteLine("--------------------");
                }
            }
            Console.ReadKey(); 

            //--------------------

            using (var context = new CarContext("CarContextString"))
            {
                //var cars = context.Cars.Include("Tyres"); //TODO: With eager loading
                var cars = context.Cars.AsEnumerable(); //TODO : Lazy loading with virtual keyword

                foreach (var car in cars)
                {
                    Console.WriteLine(car.CarId);
                    Console.WriteLine(car.Tyres.Count());
                    Console.WriteLine("--------------------");
                }
            }
            Console.ReadKey(); 

            //--------------------


        }



        public static void LazyLoading()
        {
            using (var context = new CarContext("CarContextString"))
            {
                //var cars = context.Cars.Include("Tyres"); //TODO: With eager loading
                var cars = context.Cars.AsQueryable(); //TODO : Lazy loading with virtual keyword

                foreach (var car in cars)
                {
                    Console.WriteLine(car.CarId);
                    Console.WriteLine(car.Tyres.Count());
                    Console.WriteLine("--------------------");
                }
            }
            Console.ReadKey();
        }

       

    }
}
