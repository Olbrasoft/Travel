namespace Olbrasoft.Travel.Data.Entity.Migrations.Property
{
    using System.Data.Entity.Migrations;
    
    public partial class Attributes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "Property.Attributes",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeOfAttributeId = c.Int(nullable: false),
                        SubTypeOfAttributeId = c.Int(nullable: false),
                        EanId = c.Int(nullable: false),
                        Ban = c.Boolean(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        DateAndTimeOfCreation = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Identity.Users", t => t.CreatorId, cascadeDelete: true)
                .ForeignKey("Property.SubTypesOfAttributes", t => t.SubTypeOfAttributeId)
                .ForeignKey("Property.TypesOfAttributes", t => t.TypeOfAttributeId)
                .Index(t => t.TypeOfAttributeId)
                .Index(t => t.SubTypeOfAttributeId)
                .Index(t => t.CreatorId);
        }

        public override void Down()
        {
            DropForeignKey("Property.Attributes", "TypeOfAttributeId", "Property.TypesOfAttributes");
            DropForeignKey("Property.Attributes", "SubTypeOfAttributeId", "Property.SubTypesOfAttributes");
            DropForeignKey("Property.Attributes", "CreatorId", "Identity.Users");
            DropIndex("Property.Attributes", new[] { "CreatorId" });
            DropIndex("Property.Attributes", new[] { "SubTypeOfAttributeId" });
            DropIndex("Property.Attributes", new[] { "TypeOfAttributeId" });
            DropTable("Property.Attributes");
        }
    }
}
