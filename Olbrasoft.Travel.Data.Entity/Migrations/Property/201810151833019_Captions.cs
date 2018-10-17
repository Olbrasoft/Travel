namespace Olbrasoft.Travel.Data.Entity.Migrations.Property
{
    using System.Data.Entity.Migrations;

    public partial class Captions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Property.Captions",
                c => new
                {
                    Id = c.Int(nullable: false),
                    CreatorId = c.Int(nullable: false),
                    DateAndTimeOfCreation = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Identity.Users", t => t.CreatorId, cascadeDelete: true)
                .Index(t => t.CreatorId);
        }

        public override void Down()
        {
            DropForeignKey("Property.Captions", "CreatorId", "Identity.Users");

            DropIndex("Property.Captions", new[] { "CreatorId" });

            DropTable("Property.Captions");
        }
    }
}