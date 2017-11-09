namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Vidly.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Vidly.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            //ContextKey = "Vidly.DataAccess.ApplicationDbContext";
        }

        protected override void Seed(Vidly.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            
              /*  context.Customers.AddOrUpdate(
                  p => p.Id,
                  new Customer {Id = 8, Name = "Andrew Peters", IsSubscribedToNewsLetter = true, Birthdate = new DateTime(1994-05-03), MembershipTypeId = 1},
                  new Customer { Id = 9, Name = "Ichi Moto", IsSubscribedToNewsLetter = true, Birthdate = new DateTime(1996-01-31), MembershipTypeId = 2},
                  new Customer { Id = 10, Name = "Joana Camacho", IsSubscribedToNewsLetter = true, Birthdate = new DateTime(1991-11-26), MembershipTypeId = 3}
                  );  */       

        }
    }
}


/*namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate) VALUE (1, 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate) VALUE (2, 30, 1, 10)");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate) VALUE (3, 90, 3, 15)");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate) VALUE (4, 300, 12, 20)");
        }

        public override void Down()
        {
        }
    }
} */