namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b29bd4ce-3c92-41af-8540-ee7152c4027b', N'admin@vidly.com', 0, N'AExjmzE8fmR/fVegDAiUhtj7Z4EPx419O3mGmN/Am9bC1r9GnL0JEQEDMZkKJ3g2uQ==', N'29596aaf-82aa-49c0-9794-3d1fdd51c7b2', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd92b2e32-16eb-44a6-a5df-d94167f1fea5', N'guest@vidly.com', 0, N'AMm4+r0VLSW1514Xewrv/BZUuANR/gMjetJhRJVpMRfAaUwJKeV8phBTMlcACbVL/g==', N'dee31026-56ff-4843-bea1-ee4898c73201', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'05b9b835-5f7b-44cd-a33d-08d437dec37e', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b29bd4ce-3c92-41af-8540-ee7152c4027b', N'05b9b835-5f7b-44cd-a33d-08d437dec37e')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
