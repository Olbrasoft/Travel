namespace Olbrasoft.Travel.Data.Entity.Migrations.Routing
{
    using System.Data.Entity.Migrations;

    public partial class FilesExtensions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "Routing.FilesExtensions",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Extension = c.String(nullable: false, maxLength: 50),
                        CreatorId = c.Int(nullable: false),
                        DateAndTimeOfCreation = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Identity.Users", t => t.CreatorId, cascadeDelete: true)
                .Index(t => t.Extension, unique: true)
                .Index(t => t.CreatorId);
        }

        public override void Down()
        {
            DropForeignKey("Routing.FilesExtensions", "CreatorId", "Identity.Users");
            DropIndex("Routing.FilesExtensions", new[] { "CreatorId" });
            DropIndex("Routing.FilesExtensions", new[] { "Extension" });
            DropTable("Routing.FilesExtensions");
        }
    }
}