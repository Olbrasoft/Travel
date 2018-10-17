namespace Olbrasoft.Travel.Data.Entity.Migrations.Property
{
    using System.Data.Entity.Migrations;

    public partial class PhotosOfAccommodations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "Property.PhotosOfAccommodations",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccommodationId = c.Int(nullable: false),
                        PathToPhotoId = c.Int(nullable: false),
                        FileName = c.String(maxLength: 50),
                        FileExtensionId = c.Int(nullable: false),
                        IsDefault = c.Boolean(nullable: false),
                        CaptionId = c.Int(),
                        CreatorId = c.Int(nullable: false),
                        DateAndTimeOfCreation = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Property.Accommodations", t => t.AccommodationId, cascadeDelete: true)
                .ForeignKey("Property.Captions", t => t.CaptionId)
                .ForeignKey("Identity.Users", t => t.CreatorId)
                .ForeignKey("Routing.FilesExtensions", t => t.FileExtensionId)
                .ForeignKey("Routing.PathsToPhotos", t => t.PathToPhotoId)
                .Index(t => t.AccommodationId)
                .Index(t => new { t.PathToPhotoId, t.FileName, t.FileExtensionId }, unique: true)
                .Index(t => t.CaptionId)
                .Index(t => t.CreatorId);
        }

        public override void Down()
        {
            DropForeignKey("Property.PhotosOfAccommodations", "PathToPhotoId", "Routing.PathsToPhotos");
            DropForeignKey("Property.PhotosOfAccommodations", "FileExtensionId", "Routing.FilesExtensions");
            DropForeignKey("Property.PhotosOfAccommodations", "CreatorId", "Identity.Users");
            DropForeignKey("Property.PhotosOfAccommodations", "CaptionId", "Property.Captions");
            DropForeignKey("Property.PhotosOfAccommodations", "AccommodationId", "Property.Accommodations");

            DropIndex("Property.PhotosOfAccommodations", new[] { "CreatorId" });
            DropIndex("Property.PhotosOfAccommodations", new[] { "CaptionId" });
            DropIndex("Property.PhotosOfAccommodations", new[] { "PathToPhotoId", "FileName", "FileExtensionId" });
            DropIndex("Property.PhotosOfAccommodations", new[] { "AccommodationId" });

            DropTable("Property.PhotosOfAccommodations");
        }
    }
}