1.  When we run first time code first code _migrationhistory table creates automatically. We can delete this table later as long as
	no schema changes for this.
2.	For day to day development we require migration history table so that we can have all latest migrations run over the migration 
	table
3.  You can do lazyloading by enable lazyloading true and virtual keword to property. By default LazyLoadingEnabled is true. If you need to disable you need to set explicitly LazyLoadingEnabled=false
4. You can do eager loading by include or load function



            //for (var i = 10; i < 5000; i++)
            //    context.Orders.AddOrUpdate(
            //        p => new { p.OrderedBy },
            //        new Order()
            //        {
            //            OrderedBy = "test" + i,
            //            OrderedOn = DateTime.Now,
            //            Customer = new Customer
            //            {
            //                CustomerName = "csname" + i,
            //                Address = "add" + i,
            //                PinCode = "123" + i
            //            },
            //            Products = GetProducts()
            //        }
            //    );



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
