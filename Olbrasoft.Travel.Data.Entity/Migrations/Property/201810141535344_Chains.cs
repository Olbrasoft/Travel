namespace Olbrasoft.Travel.Data.Entity.Migrations.Property
{
    using System.Data.Entity.Migrations;

    public partial class Chains : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Property.Chains",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    EanId = c.Int(nullable: false),
                    Name = c.String(nullable: false, maxLength: 30),
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
            DropForeignKey("Property.Chains", "CreatorId", "Identity.Users");
            DropIndex("Property.Chains", new[] { "CreatorId" });
            DropIndex("Property.Chains", new[] { "EanId" });
            DropTable("Property.Chains");
        }
    }
}