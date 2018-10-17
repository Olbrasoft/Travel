using System.Data.Entity.Migrations;
using Olbrasoft.Travel.Data.Entity.SqlServer;

namespace Olbrasoft.Travel.Data.Entity.Migrations
{
    /// <summary>
    /// https://translate.google.cz/#en/cs/Globalization%20Migrations%20Configuration
    /// </summary>
    internal sealed class GlobalizationMigrationsConfiguration : DatabaseMigrationsConfiguration<GlobalizationDatabaseContext>
    {
        public GlobalizationMigrationsConfiguration()
        {
            MigrationsDirectory = "Migrations\\Globalization";
            MigrationsNamespace = $"{MigrationsNamespace}.Globalization";
        }

        protected override void Seed(GlobalizationDatabaseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
