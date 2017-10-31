namespace EFMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        OrderedBy = c.String(),
                        OrderedOn = c.DateTime(nullable: false),
                        Customer_CustomerId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId)
                .Index(t => t.Customer_CustomerId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        Address = c.String(),
                        PinCode = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        AvailableDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "Customer_CustomerId", "dbo.Customers");
            DropIndex("dbo.Products", new[] { "OrderId" });
            DropIndex("dbo.Orders", new[] { "Customer_CustomerId" });
            DropTable("dbo.Products");
            DropTable("dbo.Customers");
            DropTable("dbo.Orders");
        }
    }
}
