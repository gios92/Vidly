namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'499f443b-5cf0-44b6-8ce4-815a749696aa', N'admin@vidly.com', 0, N'AF32mEBiSvXLf8t0hFaJE23w2F0RqKS7ILMDy/gHQd07io8rEyauwEJnDI0btobx2Q==', N'9db1d436-6e2d-4c3d-9698-046a1296e382', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'da281df9-2c81-4803-9324-1c0c413d9391', N'guest@vidly.com', 0, N'APkeI6wIsggiNPmQOWs6g7fEF8PlicMCyef2hD0ZXe+30Houkl3gB5ClWYOxMzAeMQ==', N'60fbeab0-b5d6-430a-b809-ed790c89d9e1', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6501d75a-793a-4519-861a-4c6792c205d5', N'CanManageMovies')
                   
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'499f443b-5cf0-44b6-8ce4-815a749696aa', N'6501d75a-793a-4519-861a-4c6792c205d5')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
