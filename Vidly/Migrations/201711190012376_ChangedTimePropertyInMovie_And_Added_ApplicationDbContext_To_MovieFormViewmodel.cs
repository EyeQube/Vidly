namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedTimePropertyInMovie_And_Added_ApplicationDbContext_To_MovieFormViewmodel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "DateAdded");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "DateAdded", c => c.DateTime());
        }
    }
}
