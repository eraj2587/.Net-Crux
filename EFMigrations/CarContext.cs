
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Diagnostics;

namespace EFMigrations
{
    class OrderContext : DbContext
    {
        public OrderContext()
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
        }

        public OrderContext(string connectionstring)
            : base("name=OrderContextString")
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
           // Configuration.AutoDetectChangesEnabled = false;
            Database.Log = s => Debug.Write(s);
          //  Database.SetInitializer<OrderContext>(new CreateDatabaseIfNotExists<OrderContext>());
          //  Database.SetInitializer(new MigrateDatabaseToLatestVersion<OrderContext, EFMigrations.Migrations.Configuration>("OrderContextString"));
        }

        public IDbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
        }

        public class CustomerMap : EntityTypeConfiguration<Customer>
        {
            public CustomerMap()
            {
                 Property(x => x.Gender).HasMaxLength(1).HasColumnType("char");
            }
        }

    }

    public class Order
    {
        public int OrderId { get; set; }
        public string OrderedBy { get; set; }
        public DateTime OrderedOn { get; set; }
        public virtual List<Product> Products { get; set; }
        public virtual Customer Customer { get; set; }
    }

    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime AvailableDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }
    }

    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string PinCode { get; set; }
        public string Gender { get; set; }
    }

}
