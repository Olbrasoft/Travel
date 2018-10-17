namespace Olbrasoft.Travel.Data.Entity.Migrations
{
    public class RoutingMigrationsConfiguration : DatabaseMigrationsConfiguration<RoutingDatabaseContext>
    {
        public RoutingMigrationsConfiguration()
        {
            MigrationsDirectory = "Migrations\\Routing";
            MigrationsNamespace = $"{MigrationsNamespace}.Routing";

        }
    }
}