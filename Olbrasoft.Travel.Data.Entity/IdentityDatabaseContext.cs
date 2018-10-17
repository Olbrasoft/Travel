using Olbrasoft.Travel.Data.Entity.Model.Configuration;
using Olbrasoft.Travel.Data.Entity.Model.Identity;
using System.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity
{
    public class IdentityDatabaseContext : Microsoft.AspNet.Identity.EntityFramework.IdentityDbContext<User, Role, int, UserLogin, Membership, UserClaim>, IIdentityContext
    {
        public IdentityDatabaseContext() : base("name=TravelConnectionString")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(typeof(EntityConfigurationWithSchemaName<>).Assembly);
        }
    }
}