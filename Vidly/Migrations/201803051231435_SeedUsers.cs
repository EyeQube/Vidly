namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0233c790-782c-4ef3-80ba-45fc24fe1ef1', N'sangin@sang.com', 0, N'APYb8P1LdXWAMiJPvNZUWP42LEIMdDiCHIl6ZOMJdGTnxOQWjKQZPSTP9ykF/Npbow==', N'74b224bb-9401-4a89-a6e3-5d0dedbc4b77', NULL, 0, 0, NULL, 1, 0, N'sangin@sang.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f7738f7c-d7e2-442f-a1f6-0c5c0ce1c671', N'admin@vidly.com', 0, N'AAltiuprvlXXCPUW7HINSWniV9bhGmyD6D5MbejSHfMw1EO/ShhS4OiXepF6UZO8Jg==', N'd2d8d8ff-f9ea-4d93-bc0d-b20e9e44575d', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'492608f8-aa80-4680-9706-08b58979766a', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f7738f7c-d7e2-442f-a1f6-0c5c0ce1c671', N'492608f8-aa80-4680-9706-08b58979766a')
              ");
        }
        
        public override void Down()
        {
        }
    }
}
