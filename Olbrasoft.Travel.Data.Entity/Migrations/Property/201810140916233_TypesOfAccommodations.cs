namespace Olbrasoft.Travel.Data.Entity.Migrations.Property
{
    using System.Data.Entity.Migrations;

    public partial class TypesOfAccommodations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Property.TypesOfAccommodations",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    EanId = c.Int(nullable: false),
                    CreatorId = c.Int(nullable: false),
                    DateAndTimeOfCreation = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Identity.Users", t => t.CreatorId, cascadeDelete: true)
                .Index(t => t.EanId, unique: true)
                .Index(t => t.CreatorId);
        }

        public override void Down()
        {
            DropForeignKey("Property.TypesOfAccommodations", "CreatorId", "Identity.Users");
            DropIndex("Property.TypesOfAccommodations", new[] { "CreatorId" });
            DropIndex("Property.TypesOfAccommodations", new[] { "EanId" });
            DropTable("Property.TypesOfAccommodations");
        }
    }
}