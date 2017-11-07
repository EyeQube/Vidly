namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '1985/05/24' WHERE Id = 4");
            Sql("UPDATE Customers SET Birthdate = '1990/11/29' WHERE Id = 5");
           

        }
        
        public override void Down()
        {
        }
    }
}
