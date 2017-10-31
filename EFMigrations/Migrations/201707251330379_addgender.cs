namespace EFMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addgender : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Gender", c => c.String(maxLength: 1, fixedLength: true, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Gender");
        }
    }
}
