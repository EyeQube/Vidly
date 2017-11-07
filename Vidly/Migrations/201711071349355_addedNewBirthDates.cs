namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedNewBirthDates : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '1980/04/20' WHERE Id = 6");
            Sql("UPDATE Customers SET Birthdate = '1988/10/02' WHERE Id = 7");

        }
        
        public override void Down()
        {
        }
    }
}
