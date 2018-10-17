namespace Olbrasoft.Travel.Data.Entity.Migrations.Property
{
    using System.Data.Entity.Migrations;

    public partial class TypesOfAttributes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Property.TypesOfAttributes",
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
            DropForeignKey("Property.TypesOfAttributes", "CreatorId", "Identity.Users");
            DropIndex("Property.TypesOfAttributes", new[] { "CreatorId" });
            DropIndex("Property.TypesOfAttributes", new[] { "Name" });
            DropTable("Property.TypesOfAttributes");
        }
    }
}