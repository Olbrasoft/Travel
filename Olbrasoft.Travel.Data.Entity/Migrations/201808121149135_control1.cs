namespace Olbrasoft.Travel.Data.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class control1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("acco.LocalizedAccommodations", "LanguageId", "dbo.Languages");
            AddForeignKey("acco.LocalizedAccommodations", "LanguageId", "dbo.Languages", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("acco.LocalizedAccommodations", "LanguageId", "dbo.Languages");
            AddForeignKey("acco.LocalizedAccommodations", "LanguageId", "dbo.Languages", "Id", cascadeDelete: true);
        }
    }
}
