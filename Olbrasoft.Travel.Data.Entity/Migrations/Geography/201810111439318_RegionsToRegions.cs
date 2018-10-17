namespace Olbrasoft.Travel.Data.Entity.Migrations.Geography
{
    using System.Data.Entity.Migrations;

    public partial class RegionsToRegions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Geography.RegionsToRegions",
                c => new
                {
                    Id = c.Int(nullable: false),
                    ToId = c.Int(nullable: false),
                    CreatorId = c.Int(nullable: false),
                    DateAndTimeOfCreation = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => new { t.Id, t.ToId })
                .ForeignKey("Identity.Users", t => t.CreatorId)
                .ForeignKey("Geography.Regions", t => t.ToId, cascadeDelete: true)
                .ForeignKey("Geography.Regions", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.ToId)
                .Index(t => t.CreatorId);
        }

        public override void Down()
        {
            DropForeignKey("Geography.RegionsToRegions", "Id", "Geography.Regions");
            DropForeignKey("Geography.RegionsToRegions", "ToId", "Geography.Regions");
            DropForeignKey("Geography.RegionsToRegions", "CreatorId", "Identity.Users");
            DropIndex("Geography.RegionsToRegions", new[] { "CreatorId" });
            DropIndex("Geography.RegionsToRegions", new[] { "ToId" });
            DropIndex("Geography.RegionsToRegions", new[] { "Id" });
            DropTable("Geography.RegionsToRegions");
        }
    }
}