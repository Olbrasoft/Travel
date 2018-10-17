using Olbrasoft.Travel.Data.Entity.Model.Configuration.Identity;
using Olbrasoft.Travel.Data.Entity.Model.Identity;
using System.Data.Entity;
using Olbrasoft.Data.Entity;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Geography;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Globalization;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Property;

namespace Olbrasoft.Travel.Data.Entity
{
    public class IdentityDatabaseContext : Microsoft.AspNet.Identity.EntityFramework.IdentityDbContext<User, Role, int, UserLogin, Membership, UserClaim>, IIdentityContext
    {
        protected IFactory ConfigurationFactory { get; }

        public IdentityDatabaseContext() : this(new Factory())
        {
        }

        public IdentityDatabaseContext(IFactory configurationFactory) : base("name=TravelConnectionString")
        {
            ConfigurationFactory = configurationFactory;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(ConfigurationFactory.Create<RegionConfiguration>());

            modelBuilder.Configurations.Add(ConfigurationFactory.Create<CountryConfiguration>());

            modelBuilder.Configurations.Add(ConfigurationFactory.Create<UserConfiguration>());

            modelBuilder.Configurations.Add(ConfigurationFactory.Create<RoleConfiguration>());

            modelBuilder.Configurations.Add(ConfigurationFactory.Create<MembershipConfiguration>());

            modelBuilder.Configurations.Add(ConfigurationFactory.Create<UserLoginConfiguration>());

            modelBuilder.Configurations.Add(ConfigurationFactory.Create<UserClaimConfiguration>());

            modelBuilder.Configurations.Add(ConfigurationFactory.Create<LocalizedDescriptionOfAccommodationConfiguration>());

            //EntityType 'AccommodationToAttribute' has no key defined. Define the key for this EntityType.AccommodationToAttributes
            modelBuilder.Configurations.Add(ConfigurationFactory.Create<AccommodationToAttributeConfiguration>());
        }
    }
}