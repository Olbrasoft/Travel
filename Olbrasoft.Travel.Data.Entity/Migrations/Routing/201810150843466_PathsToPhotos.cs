namespace Olbrasoft.Travel.Data.Entity.Migrations.Routing
{
    using System.Data.Entity.Migrations;

    public partial class PathsToPhotos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Routing.PathsToPhotos",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Path = c.String(nullable: false, maxLength: 300),
                    CreatorId = c.Int(nullable: false),
                    DateAndTimeOfCreation = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Identity.Users", t => t.CreatorId, cascadeDelete: true)
                .Index(t => t.Path, unique: true)
                .Index(t => t.CreatorId);
        }

        public override void Down()
        {
            DropForeignKey("Routing.PathsToPhotos", "CreatorId", "Identity.Users");
            DropIndex("Routing.PathsToPhotos", new[] { "CreatorId" });
            DropIndex("Routing.PathsToPhotos", new[] { "Path" });
            DropTable("Routing.PathsToPhotos");
        }
    }
}