namespace Olbrasoft.Travel.Data.Entity.Migrations.Globalization
{
    using System.Data.Entity.Migrations;

    public partial class LocalizedAccommodation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Globalization.LocalizedAccommodations",
                c => new
                {
                    Id = c.Int(nullable: false),
                    LanguageId = c.Int(nullable: false),
                    Name = c.String(nullable: false, maxLength: 70),
                    Location = c.String(maxLength: 80),
                    CheckInTime = c.String(maxLength: 10),
                    CheckOutTime = c.String(maxLength: 10),
                    CreatorId = c.Int(nullable: false),
                    DateAndTimeOfCreation = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => new { t.Id, t.LanguageId })
                .ForeignKey("Property.Accommodations", t => t.Id, cascadeDelete: true)
                .ForeignKey("Identity.Users", t => t.CreatorId)
                .ForeignKey("Globalization.Languages", t => t.LanguageId)
                .Index(t => t.Id)
                .Index(t => t.LanguageId)
                .Index(t => t.CreatorId);
        }

        public override void Down()
        {
            DropForeignKey("Globalization.LocalizedAccommodations", "LanguageId", "Globalization.Languages");
            DropForeignKey("Globalization.LocalizedAccommodations", "CreatorId", "Identity.Users");
            DropForeignKey("Globalization.LocalizedAccommodations", "Id", "Property.Accommodations");
            DropIndex("Globalization.LocalizedAccommodations", new[] { "CreatorId" });
            DropIndex("Globalization.LocalizedAccommodations", new[] { "LanguageId" });
            DropIndex("Globalization.LocalizedAccommodations", new[] { "Id" });
            DropTable("Globalization.LocalizedAccommodations");
        }
    }
}