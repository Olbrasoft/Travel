namespace Olbrasoft.Travel.Data.Entity.Migrations.Geography
{
    using System.Data.Entity.Migrations;

    public partial class Countries : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Geography.Countries",
                c => new
                {
                    Id = c.Int(nullable: false),
                    Code = c.String(nullable: false, maxLength: 2),
                    CreatorId = c.Int(nullable: false),
                    DateAndTimeOfCreation = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Identity.Users", t => t.CreatorId)
                .ForeignKey("Geography.Regions", t => t.Id, cascadeDelete: true)
                .Index(t => t.Id, unique: true)
                .Index(t => t.Code, unique: true)
                .Index(t => t.CreatorId);
        }

        public override void Down()
        {
            DropForeignKey("Geography.Countries", "Id", "Geography.Regions");
            DropForeignKey("Geography.Countries", "CreatorId", "Identity.Users");
            DropIndex("Geography.Countries", new[] { "CreatorId" });
            DropIndex("Geography.Countries", new[] { "Code" });
            DropIndex("Geography.Countries", new[] { "Id" });
            DropTable("Geography.Countries");
        }
    }
}