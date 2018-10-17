using Olbrasoft.Travel.Data.Entity.Model.Configuration.Geography;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Identity;
using Olbrasoft.Travel.Data.Entity.Model.Geography;
using System.Data.Entity;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Globalization;

namespace Olbrasoft.Travel.Data.Entity
{
    public class GeographyDatabaseContext : TravelDatabaseContext, IGeographyContext
    {
        public IDbSet<TypeOfRegion> TypesOfRegions { get; set; }
        public IDbSet<Region> Regions { get; set; }
        public IDbSet<SubClass> SubClasses { get; set; }
        public IDbSet<RegionToType> RegionsToTypes { get; set; }
        public IDbSet<RegionToRegion> RegionsToRegions { get; set; }
        public IDbSet<Country> Countries { get; set; }
        public IDbSet<Airport> Airports { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(ConfigurationFactory.Create<UserConfiguration>());
            modelBuilder.Configurations.Add(ConfigurationFactory.Create<MembershipConfiguration>());
            modelBuilder.Configurations.Add(ConfigurationFactory.Create<UserLoginConfiguration>());
            modelBuilder.Configurations.Add(ConfigurationFactory.Create<TypeOfRegionConfiguration>());
            modelBuilder.Configurations.Add(ConfigurationFactory.Create<RegionConfiguration>());
            modelBuilder.Configurations.Add(ConfigurationFactory.Create<SubClassConfiguration>());
            modelBuilder.Configurations.Add(ConfigurationFactory.Create<RegionToTypeConfiguration>());
            modelBuilder.Configurations.Add(ConfigurationFactory.Create<RegionToRegionConfiguration>());
            modelBuilder.Configurations.Add(ConfigurationFactory.Create<CountryConfiguration>());
            modelBuilder.Configurations.Add(ConfigurationFactory.Create<AirportConfiguration>());

            modelBuilder.Configurations.Add(ConfigurationFactory.Create<LocalizedRegionConfiguration>());
        }
    }
}