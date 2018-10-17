namespace Olbrasoft.Travel.Data.Entity.Migrations.Geography
{
    using System.Data.Entity.Migrations;

    public partial class Airports : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Geography.Airports",
                c => new
                {
                    Id = c.Int(nullable: false),
                    Code = c.String(nullable: false, maxLength: 3),
                    CreatorId = c.Int(nullable: false),
                    DateAndTimeOfCreation = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Geography.Regions", t => t.Id, cascadeDelete: true)
                .ForeignKey("Identity.Users", t => t.CreatorId)
                .Index(t => t.Id, unique: true)
                .Index(t => t.Code, unique: true)
                .Index(t => t.CreatorId);
        }

        public override void Down()
        {
            DropForeignKey("Geography.Airports", "CreatorId", "Identity.Users");
            DropForeignKey("Geography.Airports", "Id", "Geography.Regions");
            DropIndex("Geography.Airports", new[] { "CreatorId" });
            DropIndex("Geography.Airports", new[] { "Code" });
            DropIndex("Geography.Airports", new[] { "Id" });
            DropTable("Geography.Airports");
        }
    }
}