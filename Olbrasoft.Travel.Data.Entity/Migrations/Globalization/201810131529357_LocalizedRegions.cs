namespace Olbrasoft.Travel.Data.Entity.Migrations.Globalization
{
    using System.Data.Entity.Migrations;

    public partial class LocalizedRegions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Globalization.LocalizedRegions",
                c => new
                {
                    Id = c.Int(nullable: false),
                    LanguageId = c.Int(nullable: false),
                    Name = c.String(nullable: false, maxLength: 255),
                    LongName = c.String(maxLength: 510),
                    CreatorId = c.Int(nullable: false),
                    DateAndTimeOfCreation = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => new { t.Id, t.LanguageId })
                .ForeignKey("Identity.Users", t => t.CreatorId)
                .ForeignKey("Globalization.Languages", t => t.LanguageId)
                .ForeignKey("Geography.Regions", t => t.Id, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.LanguageId)
                .Index(t => t.CreatorId);
        }

        public override void Down()
        {
            DropForeignKey("Globalization.LocalizedRegions", "Id", "Geography.Regions");
            DropForeignKey("Globalization.LocalizedRegions", "LanguageId", "Globalization.Languages");
            DropForeignKey("Globalization.LocalizedRegions", "CreatorId", "Identity.Users");
            DropIndex("Globalization.LocalizedRegions", new[] { "CreatorId" });
            DropIndex("Globalization.LocalizedRegions", new[] { "LanguageId" });
            DropIndex("Globalization.LocalizedRegions", new[] { "Id" });
            DropTable("Globalization.LocalizedRegions");
        }
    }
}