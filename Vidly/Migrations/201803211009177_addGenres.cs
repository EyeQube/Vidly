namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Id, Genres) VALUES (1, 'Comedy')");
            Sql("INSERT INTO Genres(Id, Genres) VALUES (2, 'Action')");
            Sql("INSERT INTO Genres(Id, Genres) VALUES (3, 'Horror')");
            Sql("INSERT INTO Genres(Id, Genres) VALUES (4, 'Thriller')");
            Sql("INSERT INTO Genres(Id, Genres) VALUES (5, 'Family')");
            Sql("INSERT INTO Genres(Id, Genres) VALUES (6, 'Romance')");
            Sql("INSERT INTO Genres(Id, Genres) VALUES (7, 'Drama')");
        }
        
        public override void Down()
        {
        }
    }
}
