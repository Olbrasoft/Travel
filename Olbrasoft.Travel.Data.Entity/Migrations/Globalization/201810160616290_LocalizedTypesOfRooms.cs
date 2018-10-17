namespace Olbrasoft.Travel.Data.Entity.Migrations.Globalization
{
    using System.Data.Entity.Migrations;

    public partial class LocalizedTypesOfRooms : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "Globalization.LocalizedTypesOfRooms",
                    c => new
                    {
                        Id = c.Int(nullable: false),
                        LanguageId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 200),
                        Description = c.String(),
                        CreatorId = c.Int(nullable: false),
                        DateAndTimeOfCreation = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.Id, t.LanguageId })
                .ForeignKey("Identity.Users", t => t.CreatorId)
                .ForeignKey("Globalization.Languages", t => t.LanguageId)
                .ForeignKey("Property.TypesOfRooms", t => t.Id, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.LanguageId)
                .Index(t => t.CreatorId);
        }

        public override void Down()
        {
            DropForeignKey("Globalization.LocalizedTypesOfRooms", "Id", "Property.TypesOfRooms");
            DropForeignKey("Globalization.LocalizedTypesOfRooms", "LanguageId", "Globalization.Languages");
            DropForeignKey("Globalization.LocalizedTypesOfRooms", "CreatorId", "Identity.Users");
            DropIndex("Globalization.LocalizedTypesOfRooms", new[] { "CreatorId" });
            DropIndex("Globalization.LocalizedTypesOfRooms", new[] { "LanguageId" });
            DropIndex("Globalization.LocalizedTypesOfRooms", new[] { "Id" });
            DropTable("Globalization.LocalizedTypesOfRooms");
        }
    }
}