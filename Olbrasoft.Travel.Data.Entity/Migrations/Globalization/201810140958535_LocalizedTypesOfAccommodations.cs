namespace Olbrasoft.Travel.Data.Entity.Migrations.Globalization
{
    using System.Data.Entity.Migrations;

    public partial class LocalizedTypesOfAccommodations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Globalization.LocalizedTypesOfAccommodations",
                c => new
                {
                    Id = c.Int(nullable: false),
                    LanguageId = c.Int(nullable: false),
                    Name = c.String(nullable: false, maxLength: 256),
                    CreatorId = c.Int(nullable: false),
                    DateAndTimeOfCreation = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => new { t.Id, t.LanguageId })
                .ForeignKey("Identity.Users", t => t.CreatorId)
                .ForeignKey("Globalization.Languages", t => t.LanguageId)
                .ForeignKey("Property.TypesOfAccommodations", t => t.Id, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.LanguageId)
                .Index(t => t.CreatorId);
        }

        public override void Down()
        {
            DropForeignKey("Globalization.LocalizedTypesOfAccommodations", "Id", "Property.TypesOfAccommodations");
            DropForeignKey("Globalization.LocalizedTypesOfAccommodations", "LanguageId", "Globalization.Languages");
            DropForeignKey("Globalization.LocalizedTypesOfAccommodations", "CreatorId", "Identity.Users");
            DropIndex("Globalization.LocalizedTypesOfAccommodations", new[] { "CreatorId" });
            DropIndex("Globalization.LocalizedTypesOfAccommodations", new[] { "LanguageId" });
            DropIndex("Globalization.LocalizedTypesOfAccommodations", new[] { "Id" });
            DropTable("Globalization.LocalizedTypesOfAccommodations");
        }
    }
}