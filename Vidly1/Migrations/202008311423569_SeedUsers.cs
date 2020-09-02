namespace Vidly1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4926c8cd-1387-4bd7-b7aa-6562f1101056', N'admin@vidly.com', 0, N'ANiFDvV1CL6SUPmOxwLTSlFa1KW7iQMII89qRwfFRmOKzl15T1XT2+zsrrhOoIpSDg==', N'512f9a1e-7518-4b9d-a724-3c505279a4a8', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'92555794-89b7-4832-bc69-955b848875de', N'guest@vidly.com', 0, N'AEPxIBjre9widnJJMuy3KDnB1ZTMwS3iHiGGg6tCLj7YtWARGAj1lLdTRouRMFAmLw==', N'b9cfeec1-5d36-42a5-86ab-821a5a546fc5', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6fa4ba36-8306-48d2-b246-f86338af8f00', N'CanManageMovies')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4926c8cd-1387-4bd7-b7aa-6562f1101056', N'6fa4ba36-8306-48d2-b246-f86338af8f00')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
