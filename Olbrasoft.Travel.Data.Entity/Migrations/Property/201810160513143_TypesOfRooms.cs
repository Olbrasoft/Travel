namespace Olbrasoft.Travel.Data.Entity.Migrations.Property
{
    using System.Data.Entity.Migrations;

    public partial class TypesOfRooms : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Property.TypesOfRooms",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    AccommodationId = c.Int(nullable: false),
                    EanId = c.Int(nullable: false),
                    CreatorId = c.Int(nullable: false),
                    DateAndTimeOfCreation = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Property.Accommodations", t => t.AccommodationId, cascadeDelete: true)
                .ForeignKey("Identity.Users", t => t.CreatorId)
                .Index(t => t.AccommodationId)
                .Index(t => t.CreatorId);
        }

        public override void Down()
        {
            DropForeignKey("Property.TypesOfRooms", "CreatorId", "Identity.Users");
            DropForeignKey("Property.TypesOfRooms", "AccommodationId", "Property.Accommodations");
            DropIndex("Property.TypesOfRooms", new[] { "CreatorId" });
            DropIndex("Property.TypesOfRooms", new[] { "AccommodationId" });
            DropTable("Property.TypesOfRooms");
        }
    }
}