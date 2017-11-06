namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Vidly.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Vidly.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
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