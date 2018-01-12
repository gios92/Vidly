namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                   INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9a4d95b0-b87c-4976-87c4-ed4ecbd1845b', N'guest@vidly.com', 0, N'AM7Sva17AAtBfxTOs/Q0t2ixjZ+poAlFlVsskhqbJe4fXC4VeGKapibDbBpPNq8FjQ==', N'91560a7f-eb9b-4854-9fca-fa48b29e4d97', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                   INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd38b0abd-62eb-444c-a045-44ad9dbd2bce', N'admin@vidly.com', 0, N'AMjAqYfBsVEQiOpotrTeAHUwhByCOkorKVKvwAp8N9O2Z2m4hKk72Xxg4Gz1QXvcQg==', N'f252b570-a763-42c2-8116-102ca013463b', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

                   INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'12a4a631-8958-46da-b943-2fee66795c3f', N'CanManageMovies')

                   INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd38b0abd-62eb-444c-a045-44ad9dbd2bce', N'12a4a631-8958-46da-b943-2fee66795c3f')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
