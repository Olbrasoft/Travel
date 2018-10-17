namespace Olbrasoft.Travel.Data.Entity.Migrations.Geography
{
    using System.Data.Entity.Migrations;

    public partial class SpatialIndexToRegionsOnCoordinates : DbMigration
    {
        public override void Up()
        {
            Sql("CREATE SPATIAL INDEX [IX_Geography_Regions_Coordinates] ON [Geography].[Regions](Coordinates)");
        }

        public override void Down()
        {
            Sql("DROP INDEX [IX_Geography_Regions_Coordinates] ON [Geography].[Regions]");
        }
    }
}