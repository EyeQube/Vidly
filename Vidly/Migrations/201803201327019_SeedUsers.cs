namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@" 
                 
                 INSERT INTO [dbo].[AspNetUsers] ([Id], [DrivingLicense], [Phone], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3f496964-a4b5-4262-8f4d-b971cfa515aa', N'34567', N'76543', N'normal@vidly.com', 0, N'AKkteL820qoiTSfdlN1zIw09iGxT8UDvhStEpZHdeZT9rm/iiSjI94L2W9eLdm+alw==', N'31518539-e3e3-4184-9d84-84bcb9e85e11', NULL, 0, 0, NULL, 1, 0, N'normal@vidly.com')
                 INSERT INTO [dbo].[AspNetUsers] ([Id], [DrivingLicense], [Phone], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'96a90f69-a4f6-46ff-a20b-60eaf51059a0', N'12345', N'654321', N'admin@vidly.com', 0, N'AI2kvPsiU7is1yEbycAPmoYrCDyYsAg8DMlllMgO4ELXU6Iu/R+oLN5iW0fvkp8Xww==', N'cd4824ce-960b-48a4-9b60-03509bdea790', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                 INSERT INTO [dbo].[AspNetUsers] ([Id], [DrivingLicense], [Phone], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cd4c0954-ec28-4e59-a496-4a2ce32c907c', N'23456', N'65432', N'user3@vidly.com', 0, N'AL9ScQc9qL9jhNZPX9Jun/hriRae4gKEfi+OGt1Bzs96jbIZgNtzPY4rUHXUfcu1Qg==', N'bb8a1637-2b56-4f12-baa6-d0c3bde6bbbd', NULL, 0, 0, NULL, 1, 0, N'user3@vidly.com')

                 INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'272b7d6c-38ea-45da-913d-cdda7613ab78', N'CanManageMovies')
                 INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'edc71a0a-4f13-473f-839e-7289f03a642c', N'CanOnlyManageCustomers')

                 INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'96a90f69-a4f6-46ff-a20b-60eaf51059a0', N'272b7d6c-38ea-45da-913d-cdda7613ab78')
                 INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cd4c0954-ec28-4e59-a496-4a2ce32c907c', N'edc71a0a-4f13-473f-839e-7289f03a642c')
               
                ");
        }

        public override void Down()
        {
        }
    }
}

/*
 * 
 * 
 * INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'0233c790-782c-4ef3-80ba-45fc24fe1ef1', N'sangin@sang.com', 0, N'APYb8P1LdXWAMiJPvNZUWP42LEIMdDiCHIl6ZOMJdGTnxOQWjKQZPSTP9ykF/Npbow==', N'74b224bb-9401-4a89-a6e3-5d0dedbc4b77', NULL, 0, 0, NULL, 1, 0, N'sangin@sang.com')
                 INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'f7738f7c-d7e2-442f-a1f6-0c5c0ce1c671', N'admin@vidly.com', 0, N'AAltiuprvlXXCPUW7HINSWniV9bhGmyD6D5MbejSHfMw1EO/ShhS4OiXepF6UZO8Jg==', N'd2d8d8ff-f9ea-4d93-bc0d-b20e9e44575d', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

    INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [Phone]) VALUES(N'1580d157-07f5-4f51-9e10-d56fee1270f2', N'user1@vidly.com', 0, N'ALv/ewUQZUHzbIQxPA6MYJ3hZWsk7R7aJ5kKYFr0c/9cdjyyxl8WjbFA5y4P07sH7g==', N'a9907027-aef9-4763-9462-0e702dbe4664', NULL, 0, 0, NULL, 1, 0, N'user1@vidly.com', N'12345', N'')
                INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [Phone]) VALUES(N'3dc12b06-1be9-4b72-91f2-e9e83690f1da', N'Phone@telefon.com', 0, N'ADEsf2Ljo1SCScOX3ETiskwA7fw2OqeC49Ju8ALuLKC6poX+zQxCEOdDEPKL7m6qcA==', N'53dad5f0-e38a-46d4-9fbd-de608647e448', NULL, 0, 0, NULL, 1, 0, N'Phone@telefon.com', N'54321', N'0790567890')
                INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [Phone]) VALUES(N'7ec39acc-b0aa-4c8d-9b0f-8e48bb2b8e11', N'user4@vidly.com', 0, N'ABLsPLOFhWFpm+GkUoVXoYFm2XpnDXK+AZNmBwBWYxv8s8fSA4G6oWj14/rzxjjrbQ==', N'37d2de50-67a0-4c57-a513-40b6339b5b8d', NULL, 0, 0, NULL, 1, 0, N'user4@vidly.com', N'99999', N'88888')
                INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [Phone]) VALUES(N'8b45232f-7ce6-490f-b8a6-f08b6445fd3b', N'user3@vidly.com', 0, N'AAxpipw+poWlXKHAiPSRkvRc7CDUFbHLzN6VJ8ocKG9h1fye57cyo3+MQ+OCraEy2g==', N'e18aa93c-860f-4b5f-b246-4efc6b21240f', NULL, 0, 0, NULL, 1, 0, N'user3@vidly.com', N'123456', N'654321') 

               INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4fb430af-6390-4607-adec-6142ac6fc207', N'CanOnlyManageCustomers')

    INSERT INTO[dbo].[AspNetRoles] ([Id], [Name]) VALUES(N'492608f8-aa80-4680-9706-08b58979766a', N'CanManageMovies') 
                

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f7738f7c-d7e2-442f-a1f6-0c5c0ce1c671', N'492608f8-aa80-4680-9706-08b58979766a')

               INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'21cc9ac2-8a02-4d15-ac6a-b0a443382f1e', N'4fb430af-6390-4607-adec-6142ac6fc207')
*/
