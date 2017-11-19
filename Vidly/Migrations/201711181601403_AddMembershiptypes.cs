namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershiptypes : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO Membershiptypes(Id, SignUpFee, DurationInMonths, DiscountRate, MembershipTypeName) VALUES (1, 0, 0, 0, 'Sign As You Go')");
            Sql("INSERT INTO Membershiptypes(Id, SignUpFee, DurationInMonths, DiscountRate, MembershipTypeName) VALUES (2, 30, 1, 10, 'Monthly')");
            Sql("INSERT INTO Membershiptypes(Id, SignUpFee, DurationInMonths, DiscountRate, MembershipTypeName) VALUES (3, 90, 3, 15, 'Quarterly')");
            Sql("INSERT INTO Membershiptypes(Id, SignUpFee, DurationInMonths, DiscountRate, MembershipTypeName) VALUES (4, 300, 12, 20, 'Annual')");
     
        }
        
        public override void Down()
        {
        }
    }
}
