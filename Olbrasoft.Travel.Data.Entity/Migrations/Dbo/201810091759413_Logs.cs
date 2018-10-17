namespace Olbrasoft.Travel.Data.Entity.Migrations.Dbo
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Logs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(nullable: false, maxLength: 255),
                        LevelId = c.Int(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        DateAndTimeOfCreation = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CreatorId)
                .ForeignKey("dbo.LogLevels", t => t.LevelId, cascadeDelete: true)
                .Index(t => t.LevelId)
                .Index(t => t.CreatorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Logs", "LevelId", "dbo.LogLevels");
            DropForeignKey("dbo.Logs", "CreatorId", "dbo.Users");
            DropIndex("dbo.Logs", new[] { "CreatorId" });
            DropIndex("dbo.Logs", new[] { "LevelId" });
            DropTable("dbo.Logs");
        }
    }
}
