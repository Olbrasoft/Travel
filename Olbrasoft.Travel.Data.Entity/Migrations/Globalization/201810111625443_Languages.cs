namespace Olbrasoft.Travel.Data.Entity.Migrations.Globalization
{
    using System.Data.Entity.Migrations;

    public partial class Languages : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Globalization.Languages",
                c => new
                {
                    Id = c.Int(nullable: false),
                    EanLanguageCode = c.String(nullable: false, maxLength: 5),
                    CreatorId = c.Int(nullable: false),
                    DateAndTimeOfCreation = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Identity.Users", t => t.CreatorId, cascadeDelete: true)
                .Index(t => t.EanLanguageCode, unique: true)
                .Index(t => t.CreatorId);
        }

        public override void Down()
        {
            DropForeignKey("Globalization.Languages", "CreatorId", "Identity.Users");

            DropTable("Globalization.Languages");
        }
    }
}