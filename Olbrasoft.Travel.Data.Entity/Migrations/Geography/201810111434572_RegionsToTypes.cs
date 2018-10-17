namespace Olbrasoft.Travel.Data.Entity.Migrations.Geography
{
    using System.Data.Entity.Migrations;

    public partial class RegionsToTypes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Geography.RegionsToTypes",
                c => new
                {
                    Id = c.Int(nullable: false),
                    ToId = c.Int(nullable: false),
                    SubClassId = c.Int(),
                    CreatorId = c.Int(nullable: false),
                    DateAndTimeOfCreation = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => new { t.Id, t.ToId })
                .ForeignKey("Identity.Users", t => t.CreatorId)
                .ForeignKey("Geography.Regions", t => t.Id, cascadeDelete: true)
                .ForeignKey("Geography.SubClasses", t => t.SubClassId)
                .ForeignKey("Geography.TypesOfRegions", t => t.ToId)
                .Index(t => t.Id)
                .Index(t => t.ToId)
                .Index(t => t.SubClassId)
                .Index(t => t.CreatorId);
        }

        public override void Down()
        {
            DropForeignKey("Geography.RegionsToTypes", "ToId", "Geography.TypesOfRegions");
            DropForeignKey("Geography.RegionsToTypes", "SubClassId", "Geography.SubClasses");
            DropForeignKey("Geography.RegionsToTypes", "Id", "Geography.Regions");
            DropForeignKey("Geography.RegionsToTypes", "CreatorId", "Identity.Users");
            DropIndex("Geography.RegionsToTypes", new[] { "CreatorId" });
            DropIndex("Geography.RegionsToTypes", new[] { "SubClassId" });
            DropIndex("Geography.RegionsToTypes", new[] { "ToId" });
            DropIndex("Geography.RegionsToTypes", new[] { "Id" });
            DropTable("Geography.RegionsToTypes");
        }
    }
}