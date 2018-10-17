namespace Olbrasoft.Travel.Data.Entity.Migrations.Geography
{
    using System.Data.Entity.Migrations;

    public partial class SpatialIndexToRegionsOnCenterCoordinates : DbMigration
    {
        public override void Up()
        {
            Sql("CREATE SPATIAL INDEX [IX_Geography_Regions_CenterCoordinates] ON [Geography].[Regions](CenterCoordinates)");
        }

        public override void Down()
        {
            Sql("DROP INDEX [IX_Geography_Regions_CenterCoordinates] ON [Geography].[Regions]");
        }
    }
}