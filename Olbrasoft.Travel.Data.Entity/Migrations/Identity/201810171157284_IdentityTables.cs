namespace Olbrasoft.Travel.Data.Entity.Migrations.Identity
{
    using System.Data.Entity.Migrations;
    
    public partial class IdentityTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Identity.Roles",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    DateAndTimeOfCreation = c.DateTime(nullable: false),
                    Name = c.String(nullable: false, maxLength: 256),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");

            CreateTable(
                "Identity.Memberships",
                c => new
                {
                    UserId = c.Int(nullable: false),
                    RoleId = c.Int(nullable: false),
                    DateAndTimeOfCreation = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("Identity.Roles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("Identity.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);

            CreateTable(
                "Identity.Users",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    DateAndTimeOfCreation = c.DateTime(nullable: false),
                    Email = c.String(maxLength: 256),
                    EmailConfirmed = c.Boolean(nullable: false),
                    PasswordHash = c.String(),
                    SecurityStamp = c.String(),
                    PhoneNumber = c.String(),
                    PhoneNumberConfirmed = c.Boolean(nullable: false),
                    TwoFactorEnabled = c.Boolean(nullable: false),
                    LockoutEndDateUtc = c.DateTime(),
                    LockoutEnabled = c.Boolean(nullable: false),
                    AccessFailedCount = c.Int(nullable: false),
                    UserName = c.String(nullable: false, maxLength: 256),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");

            CreateTable(
                "Identity.UsersClaims",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    DateAndTimeOfCreation = c.DateTime(nullable: false),
                    UserId = c.Int(nullable: false),
                    ClaimType = c.String(),
                    ClaimValue = c.String(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Identity.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);

            CreateTable(
                "Identity.UsersLogins",
                c => new
                {
                    LoginProvider = c.String(nullable: false, maxLength: 128),
                    ProviderKey = c.String(nullable: false, maxLength: 128),
                    UserId = c.Int(nullable: false),
                    DateAndTimeOfCreation = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("Identity.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
        }

        public override void Down()
        {
            DropForeignKey("Identity.Memberships", "UserId", "Identity.Users");
            DropForeignKey("Identity.UsersLogins", "UserId", "Identity.Users");
            DropForeignKey("Identity.UsersClaims", "UserId", "Identity.Users");
            DropForeignKey("Identity.Memberships", "RoleId", "Identity.Roles");
            DropIndex("Identity.UsersLogins", new[] { "UserId" });
            DropIndex("Identity.UsersClaims", new[] { "UserId" });
            DropIndex("Identity.Users", "UserNameIndex");
            DropIndex("Identity.Memberships", new[] { "RoleId" });
            DropIndex("Identity.Memberships", new[] { "UserId" });
            DropIndex("Identity.Roles", "RoleNameIndex");
            DropTable("Identity.UsersLogins");
            DropTable("Identity.UsersClaims");
            DropTable("Identity.Users");
            DropTable("Identity.Memberships");
            DropTable("Identity.Roles");
        }
    }
}
