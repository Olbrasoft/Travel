namespace Olbrasoft.Travel.Data.Entity.Migrations
{
    public class IdentityMigrationsConfiguration : DatabaseMigrationsConfiguration<IdentityDatabaseContext>
    {
        public IdentityMigrationsConfiguration()
        {
            MigrationsDirectory = "Migrations\\Identity";
            MigrationsNamespace = $"{MigrationsNamespace}.Identity";
        }
    }
}