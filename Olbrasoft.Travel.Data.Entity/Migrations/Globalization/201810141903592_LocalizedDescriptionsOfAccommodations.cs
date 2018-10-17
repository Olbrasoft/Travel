namespace Olbrasoft.Travel.Data.Entity.Migrations.Globalization
{
    using System.Data.Entity.Migrations;

    public partial class LocalizedDescriptionsOfAccommodations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Globalization.LocalizedDescriptionsOfAccommodations",
                c => new
                {
                    AccommodationId = c.Int(nullable: false),
                    TypeOfDescriptionId = c.Int(nullable: false),
                    LanguageId = c.Int(nullable: false),
                    Text = c.String(nullable: false),
                    CreatorId = c.Int(nullable: false),
                    DateAndTimeOfCreation = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => new { t.AccommodationId, t.TypeOfDescriptionId, t.LanguageId })
                .ForeignKey("Property.Accommodations", t => t.AccommodationId, cascadeDelete: true)
                .ForeignKey("Identity.Users", t => t.CreatorId)
                .ForeignKey("Globalization.Languages", t => t.LanguageId)
                .ForeignKey("Property.TypesOfDescriptions", t => t.TypeOfDescriptionId)
                .Index(t => t.AccommodationId)
                .Index(t => t.TypeOfDescriptionId)
                .Index(t => t.LanguageId)
                .Index(t => t.CreatorId);
        }

        public override void Down()
        {
            DropForeignKey("Globalization.LocalizedDescriptionsOfAccommodations", "TypeOfDescriptionId", "Property.TypesOfDescriptions");
            DropForeignKey("Globalization.LocalizedDescriptionsOfAccommodations", "LanguageId", "Globalization.Languages");
            DropForeignKey("Globalization.LocalizedDescriptionsOfAccommodations", "CreatorId", "Identity.Users");
            DropForeignKey("Globalization.LocalizedDescriptionsOfAccommodations", "AccommodationId", "Property.Accommodations");
            DropIndex("Globalization.LocalizedDescriptionsOfAccommodations", new[] { "CreatorId" });
            DropIndex("Globalization.LocalizedDescriptionsOfAccommodations", new[] { "LanguageId" });
            DropIndex("Globalization.LocalizedDescriptionsOfAccommodations", new[] { "TypeOfDescriptionId" });
            DropIndex("Globalization.LocalizedDescriptionsOfAccommodations", new[] { "AccommodationId" });
            DropTable("Globalization.LocalizedDescriptionsOfAccommodations");
        }
    }
}