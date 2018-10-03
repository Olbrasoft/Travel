namespace Olbrasoft.Travel.Data.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBanToAttribute : DbMigration
    {
        public override void Up()
        {
            AddColumn("acco.Attributes", "Ban", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("acco.Attributes", "Ban");
        }
    }
}
