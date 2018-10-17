namespace Olbrasoft.Travel.Data.Entity.Migrations.Geography
{
    using System.Data.Entity.Migrations;

    public partial class SubClasses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Geography.SubClasses",
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
            DropForeignKey("Geography.SubClasses", "CreatorId", "Identity.Users");
            DropIndex("Geography.SubClasses", new[] { "CreatorId" });
            DropIndex("Geography.SubClasses", new[] { "Name" });
            DropTable("Geography.SubClasses");
        }
    }
}