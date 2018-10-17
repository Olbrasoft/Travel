using System.Data.Entity;
using System.Data.Entity.Migrations;
using Olbrasoft.Travel.Data.Entity.SqlServer;

namespace Olbrasoft.Travel.Data.Entity.Migrations
{
    public abstract class DatabaseMigrationsConfiguration<TContext> : DbMigrationsConfiguration<TContext> where TContext : DbContext
    {
        protected DatabaseMigrationsConfiguration()
        {
            AutomaticMigrationsEnabled = false;
            SetSqlGenerator("System.Data.SqlClient", new CustomSqlServerMigrationSqlGenerator());
        }
    }
}