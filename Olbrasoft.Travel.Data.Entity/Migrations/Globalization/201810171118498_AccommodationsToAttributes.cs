namespace Olbrasoft.Travel.Data.Entity.Migrations.Globalization
{
    using System.Data.Entity.Migrations;

    public partial class AccommodationsToAttributes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "Globalization.AccommodationsToAttributes",
                    c => new
                    {
                        AccommodationId = c.Int(nullable: false),
                        AttributeId = c.Int(nullable: false),
                        LanguageId = c.Int(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        Text = c.String(maxLength: 800),
                        DateAndTimeOfCreation = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.AccommodationId, t.AttributeId, t.LanguageId })
                .ForeignKey("Property.Accommodations", t => t.AccommodationId, cascadeDelete: true)
                .ForeignKey("Property.Attributes", t => t.AttributeId)
                .ForeignKey("Identity.Users", t => t.CreatorId)
                .ForeignKey("Globalization.Languages", t => t.LanguageId)
                .Index(t => t.AccommodationId)
                .Index(t => t.AttributeId)
                .Index(t => t.LanguageId)
                .Index(t => t.CreatorId);
        }

        public override void Down()
        {
            DropForeignKey("Globalization.AccommodationsToAttributes", "LanguageId", "Globalization.Languages");
            DropForeignKey("Globalization.AccommodationsToAttributes", "CreatorId", "Identity.Users");
            DropForeignKey("Globalization.AccommodationsToAttributes", "AttributeId", "Property.Attributes");
            DropForeignKey("Globalization.AccommodationsToAttributes", "AccommodationId", "Property.Accommodations");
            DropIndex("Globalization.AccommodationsToAttributes", new[] { "CreatorId" });
            DropIndex("Globalization.AccommodationsToAttributes", new[] { "LanguageId" });
            DropIndex("Globalization.AccommodationsToAttributes", new[] { "AttributeId" });
            DropIndex("Globalization.AccommodationsToAttributes", new[] { "AccommodationId" });
            DropTable("Globalization.AccommodationsToAttributes");
        }
    }
}