namespace Olbrasoft.Travel.Data.Entity.Migrations.Property
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TypesOfDescriptions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Property.TypesOfDescriptions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        CreatorId = c.Int(nullable: false),
                        DateAndTimeOfCreation = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Identity.Users", t => t.CreatorId, cascadeDelete: true)
                .Index(t => t.Name, unique: true)
                .Index(t => t.CreatorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Property.TypesOfDescriptions", "CreatorId", "Identity.Users");
            DropIndex("Property.TypesOfDescriptions", new[] { "CreatorId" });
            DropIndex("Property.TypesOfDescriptions", new[] { "Name" });
            DropTable("Property.TypesOfDescriptions");
        }
    }
}
