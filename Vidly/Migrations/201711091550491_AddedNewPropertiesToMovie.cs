namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNewPropertiesToMovie : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES (Comedy, )");

        }
        
        public override void Down()
        {
        }
    }
}
