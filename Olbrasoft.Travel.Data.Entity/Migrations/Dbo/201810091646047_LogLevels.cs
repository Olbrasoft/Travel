namespace Olbrasoft.Travel.Data.Entity.Migrations.Dbo
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LogLevels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LogLevels",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 250),
                        CreatorId = c.Int(nullable: false),
                        DateAndTimeOfCreation = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CreatorId, cascadeDelete: true)
                .Index(t => t.Name, unique: true)
                .Index(t => t.CreatorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LogLevels", "CreatorId", "dbo.Users");
            DropIndex("dbo.LogLevels", new[] { "CreatorId" });
            DropIndex("dbo.LogLevels", new[] { "Name" });
            DropTable("dbo.LogLevels");
        }
    }
}
