namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomers : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Customers", new[] { "MembershipTypeId" });
            DropPrimaryKey("dbo.Customers");
            AlterColumn("dbo.Customers", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Customers", "MembershipTypeId", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Customers", "Id");
            CreateIndex("dbo.Customers", "MembershipTypeId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Customers", new[] { "MembershipTypeId" });
            DropPrimaryKey("dbo.Customers");
            AlterColumn("dbo.Customers", "MembershipTypeId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Customers", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Customers", "Id");
            CreateIndex("dbo.Customers", "MembershipTypeId");
        }
    }
}
