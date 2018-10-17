namespace Olbrasoft.Travel.Data.Entity.Migrations.Property
{
    using System.Data.Entity.Migrations;

    public partial class SpatialIndexToAccommodationsOnCenterCoordinates : DbMigration
    {
        public override void Up()
        {
            Sql("CREATE SPATIAL INDEX [IX_Property_Accommodations_CenterCoordinates] ON [Property].[Accommodations](CenterCoordinates)");
        }

        public override void Down()
        {
            Sql("DROP INDEX [IX_Property_Accommodations_CenterCoordinates] ON [Property].[Accommodations]");
        }
    }
}