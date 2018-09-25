namespace mvcOne.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedinguser : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0a90b5ab-bc08-4f7e-b605-b52cb2c27f6d', N'mzuhaib@gmail.com', 0, N'AMf1coZlGf2kppwu4F5xsbhvVtJi+sIPPifENDDGNXBnwL7/xDGR2lazuiOSdL/iIQ==', N'f6bd3ab2-fb61-49b0-9408-da128e5434a4', NULL, 0, 0, NULL, 0, 0, N'mzuhaib@gmail.com')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0fb1ea43-d8e8-44b3-b997-4aa04957ad6f', N'asad@gmail.com', 0, N'AH+/odbIUNDCEKYW/3DSMbpia8ZRtKqHbGpGp0VOiFxBfUOdcqFiKG+cZb7OTJzFjA==', N'90809a0b-8d86-41e8-ae86-2de6990bf046', NULL, 0, 0, NULL, 0, 0, N'asad@gmail.com')
                  
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0a90b5ab-bc08-4f7e-b605-b52cb2c27f6d', N'mzuhaib@gmail.com', 0, N'AMf1coZlGf2kppwu4F5xsbhvVtJi+sIPPifENDDGNXBnwL7/xDGR2lazuiOSdL/iIQ==', N'f6bd3ab2-fb61-49b0-9408-da128e5434a4', NULL, 0, 0, NULL, 0, 0, N'mzuhaib@gmail.com')
 
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0a90b5ab-bc08-4f7e-b605-b52cb2c27f6d', N'4e102586-faf5-4241-9510-15a496ba1ce2')

");

                
        }
        
        public override void Down()
        {
        }
    }
}
