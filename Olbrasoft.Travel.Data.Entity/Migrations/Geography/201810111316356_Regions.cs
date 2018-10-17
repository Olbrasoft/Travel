namespace Olbrasoft.Travel.Data.Entity.Migrations.Geography
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Regions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Geography.Regions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Coordinates = c.Geography(),
                        CenterCoordinates = c.Geography(),
                        EanId = c.Long(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        DateAndTimeOfCreation = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Identity.Users", t => t.CreatorId)
                .Index(t => t.EanId, unique: true)
                .Index(t => t.CreatorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Geography.Regions", "CreatorId", "Identity.Users");
            DropIndex("Geography.Regions", new[] { "CreatorId" });
            DropIndex("Geography.Regions", new[] { "EanId" });
            DropTable("Geography.Regions");
        }
    }
}
