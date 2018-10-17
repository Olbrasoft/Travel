using Olbrasoft.Travel.Data.Entity.Model.Routing;
using System.Data.Entity;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Geography;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Globalization;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Identity;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Routing;

namespace Olbrasoft.Travel.Data.Entity
{
    public class RoutingDatabaseContext : TravelDatabaseContext, IRoutingContext
    {
        public IDbSet<PathToPhoto> PathsToPhotos { get; set; }
        public IDbSet<FileExtension> FilesExtensions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(ConfigurationFactory.Create<UserConfiguration>());
            modelBuilder.Configurations.Add(ConfigurationFactory.Create<UserLoginConfiguration>());
            modelBuilder.Configurations.Add(ConfigurationFactory.Create<MembershipConfiguration>());

            modelBuilder.Configurations.Add(ConfigurationFactory.Create<RegionConfiguration>());
            modelBuilder.Configurations.Add(ConfigurationFactory.Create<AirportConfiguration>());

            modelBuilder.Configurations.Add(ConfigurationFactory.Create<LocalizedDescriptionOfAccommodationConfiguration>());

            modelBuilder.Configurations.Add(ConfigurationFactory.Create<PathToPhotoConfiguration>());
            modelBuilder.Configurations.Add(ConfigurationFactory.Create<FileExtensionConfiguration>());


        }
    }
}