namespace EFMigrations.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFMigrations.OrderContext>
    {   
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFMigrations.OrderContext context)
        {
            for (var i = 1; i < 5000; i++)
                context.Orders.AddOrUpdate(
                    p => new { p.OrderedBy },
                    new Order()
                    {
                        OrderedBy = "test" + i,
                        OrderedOn = DateTime.Now,
                        Customer = new Customer
                        {
                            CustomerName = "csname" + i,
                            Address = "add" + i,
                            PinCode = "123" + i
                        },
                        Products = GetProducts()
                    }
                );
        }


        private List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product()
                {
                    ProductName = "ABC",
                    Price = 10.23,
                    AvailableDate = DateTime.Now,
                    Description = "This is test product",
                    EndDate = DateTime.Now.AddDays(30)
                },
                new Product()
                {
                    ProductName = "KYC",
                    Price = 34.12,
                    AvailableDate = DateTime.Now,
                    Description = "This is again test product",
                    EndDate = DateTime.Now.AddDays(32)
                }
            };
        }

    }
}
