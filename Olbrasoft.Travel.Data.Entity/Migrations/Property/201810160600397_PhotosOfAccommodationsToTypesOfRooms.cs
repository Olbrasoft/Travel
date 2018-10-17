namespace Olbrasoft.Travel.Data.Entity.Migrations.Property
{
    using System.Data.Entity.Migrations;

    public partial class PhotosOfAccommodationsToTypesOfRooms : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Property.PhotosOfAccommodationsToTypesOfRooms",
                c => new
                {
                    Id = c.Int(nullable: false),
                    ToId = c.Int(nullable: false),
                    CreatorId = c.Int(nullable: false),
                    DateAndTimeOfCreation = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => new { t.Id, t.ToId })
                .ForeignKey("Identity.Users", t => t.CreatorId)
                .ForeignKey("Property.PhotosOfAccommodations", t => t.Id, cascadeDelete: true)
                .ForeignKey("Property.TypesOfRooms", t => t.ToId)
                .Index(t => t.Id)
                .Index(t => t.ToId)
                .Index(t => t.CreatorId);
        }

        public override void Down()
        {
            DropForeignKey("Property.PhotosOfAccommodationsToTypesOfRooms", "ToId", "Property.TypesOfRooms");
            DropForeignKey("Property.PhotosOfAccommodationsToTypesOfRooms", "Id", "Property.PhotosOfAccommodations");
            DropForeignKey("Property.PhotosOfAccommodationsToTypesOfRooms", "CreatorId", "Identity.Users");
            DropIndex("Property.PhotosOfAccommodationsToTypesOfRooms", new[] { "CreatorId" });
            DropIndex("Property.PhotosOfAccommodationsToTypesOfRooms", new[] { "ToId" });
            DropIndex("Property.PhotosOfAccommodationsToTypesOfRooms", new[] { "Id" });
            DropTable("Property.PhotosOfAccommodationsToTypesOfRooms");
        }
    }
}