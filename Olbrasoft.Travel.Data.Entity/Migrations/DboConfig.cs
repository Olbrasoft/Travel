using Olbrasoft.Travel.Data.Entity.SqlServer;

namespace Olbrasoft.Travel.Data.Entity.Migrations
{
    using System.Data.Entity.Migrations;
    /// <inheritdoc />
    /// <summary>
    ///  Add-Migration Users -ConfigurationTypeName DboConfig
    ///  Update-Database -ConfigurationTypeName DboConfig
    /// </summary>
    internal sealed class DboConfig : DbMigrationsConfiguration<DboContext>
    {
        public DboConfig()
        {
            AutomaticMigrationsEnabled = false;
            SetSqlGenerator("System.Data.SqlClient", new CustomSqlServerMigrationSqlGenerator());
        }

        protected override void Seed(DboContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}