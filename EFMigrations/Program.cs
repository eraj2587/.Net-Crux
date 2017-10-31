using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;

namespace EFMigrations
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var context = new OrderContext("OrderContextString"))
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();


                var orders = context.Orders.Take(5).ToList(); 
                //var orders = context.Orders.ToList();

                foreach (var order in orders)
                {
                    Console.WriteLine("Customer ordered {0} products", order.Products.Count);
                    Console.WriteLine("Customer name is {0} ", order.Customer.CustomerName);
                }
                watch.Stop();
                Console.WriteLine("Elabpsed time : "+ watch.ElapsedMilliseconds);
                Console.ReadKey();
            }
        }

       
    }
}
