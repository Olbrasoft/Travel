using Olbrasoft.Travel.Data.Entity.Model.Configuration;
using System.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity
{
    public class TravelDatabaseContext : DbContext, ITravelContext
    {
        protected TravelDatabaseContext() : base("name=TravelConnectionString")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(typeof(EntityConfigurationWithSchemaName<>).Assembly);
        }
    }
}