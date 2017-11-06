namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershiptypeNameToMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "MembershiptypeName", c => c.String(nullable: false, maxLength: 40));
            DropColumn("dbo.Customers", "MembershipTypeName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "MembershipTypeName", c => c.String(nullable: false, maxLength: 40));
            DropColumn("dbo.MembershipTypes", "MembershiptypeName");
        }
    }
}
