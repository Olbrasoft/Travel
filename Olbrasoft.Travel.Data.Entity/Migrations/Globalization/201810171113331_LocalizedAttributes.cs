namespace Olbrasoft.Travel.Data.Entity.Migrations.Globalization
{
    using System.Data.Entity.Migrations;

    public partial class LocalizedAttributes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "Globalization.LocalizedAttributes",
                    c => new
                    {
                        Id = c.Int(nullable: false),
                        LanguageId = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 255),
                        CreatorId = c.Int(nullable: false),
                        DateAndTimeOfCreation = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.Id, t.LanguageId })
                .ForeignKey("Property.Attributes", t => t.Id, cascadeDelete: true)
                .ForeignKey("Identity.Users", t => t.CreatorId)
                .ForeignKey("Globalization.Languages", t => t.LanguageId)
                .Index(t => t.Id)
                .Index(t => t.LanguageId)
                .Index(t => t.CreatorId);
        }

        public override void Down()
        {
            DropForeignKey("Globalization.LocalizedAttributes", "LanguageId", "Globalization.Languages");
            DropForeignKey("Globalization.LocalizedAttributes", "CreatorId", "Identity.Users");
            DropForeignKey("Globalization.LocalizedAttributes", "Id", "Property.Attributes");
            DropIndex("Globalization.LocalizedAttributes", new[] { "CreatorId" });
            DropIndex("Globalization.LocalizedAttributes", new[] { "LanguageId" });
            DropIndex("Globalization.LocalizedAttributes", new[] { "Id" });
            DropTable("Globalization.LocalizedAttributes");
        }
    }
}