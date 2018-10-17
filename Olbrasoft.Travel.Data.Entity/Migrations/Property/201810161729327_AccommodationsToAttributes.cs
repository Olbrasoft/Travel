namespace Olbrasoft.Travel.Data.Entity.Migrations.Property
{
    using System.Data.Entity.Migrations;

    public partial class AccommodationsToAttributes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Property.AccommodationsToAttributes",
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
            DropIndex("Property.AccommodationsToAttributes", new[] { "CreatorId" });
            DropIndex("Property.AccommodationsToAttributes", new[] { "LanguageId" });
            DropIndex("Property.AccommodationsToAttributes", new[] { "AttributeId" });
            DropIndex("Property.AccommodationsToAttributes", new[] { "AccommodationId" });
            DropTable("Property.AccommodationsToAttributes");
        }
    }
}