namespace Olbrasoft.Travel.Data.Entity.Migrations.Property
{
    using System.Data.Entity.Migrations;

    public partial class Accommodations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Property.Accommodations",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    SequenceNumber = c.Int(nullable: false),
                    StarRating = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Address = c.String(nullable: false, maxLength: 50),
                    AdditionalAddress = c.String(maxLength: 50),
                    CenterCoordinates = c.Geography(nullable: false),
                    TypeOfAccommodationId = c.Int(nullable: false),
                    CountryId = c.Int(nullable: false),
                    AirportId = c.Int(),
                    ChainId = c.Int(),
                    EanId = c.Int(nullable: false),
                    CreatorId = c.Int(nullable: false),
                    DateAndTimeOfCreation = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Geography.Airports", t => t.AirportId)
                .ForeignKey("Geography.Countries", t => t.CountryId)
                .ForeignKey("Identity.Users", t => t.CreatorId)
                .ForeignKey("Property.Chains", t => t.ChainId)
                .ForeignKey("Property.TypesOfAccommodations", t => t.TypeOfAccommodationId, cascadeDelete: true)
                .Index(t => t.TypeOfAccommodationId)
                .Index(t => t.CountryId)
                .Index(t => t.AirportId)
                .Index(t => t.ChainId)
                .Index(t => t.EanId, unique: true)
                .Index(t => t.CreatorId);
        }

        public override void Down()
        {
            DropForeignKey("Property.Accommodations", "TypeOfAccommodationId", "Property.TypesOfAccommodations");
            DropForeignKey("Property.Accommodations", "ChainId", "Property.Chains");
            DropForeignKey("Property.Accommodations", "CreatorId", "Identity.Users");
            DropForeignKey("Property.Accommodations", "CountryId", "Geography.Countries");
            DropForeignKey("Property.Accommodations", "AirportId", "Geography.Airports");
            DropIndex("Property.Accommodations", new[] { "CreatorId" });
            DropIndex("Property.Accommodations", new[] { "EanId" });
            DropIndex("Property.Accommodations", new[] { "ChainId" });
            DropIndex("Property.Accommodations", new[] { "AirportId" });
            DropIndex("Property.Accommodations", new[] { "CountryId" });
            DropIndex("Property.Accommodations", new[] { "TypeOfAccommodationId" });
            DropTable("Property.Accommodations");
        }
    }
}