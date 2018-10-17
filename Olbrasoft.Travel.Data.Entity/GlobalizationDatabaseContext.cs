using System.Data.Entity;
using Olbrasoft.Travel.Data.Entity.Model.Configuration;
using Olbrasoft.Travel.Data.Entity.Model.Property;
using Olbrasoft.Travel.Data.Entity.Model.Globalization;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Identity;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Property;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Geography;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Globalization;

namespace Olbrasoft.Travel.Data.Entity
{
    public class GlobalizationDatabaseContext : TravelDatabaseContext, IGlobalizationContext
    {
        public IDbSet<Language> Languages { get; set; }
        public IDbSet<LocalizedRegion> LocalizedRegions { get; set; }
        public IDbSet<LocalizedTypeOfAccommodation> LocalizedTypesOfAccommodations { get; set; }
        public IDbSet<LocalizedAccommodation> LocalizedAccommodations { get; set; }
        public IDbSet<LocalizedDescriptionOfAccommodation> LocalizedDescriptionsOfAccommodations { get; set; }
        public IDbSet<LocalizedCaption> LocalizedCaptions { get; set; }
        public IDbSet<LocalizedTypeOfRoom> LocalizedTypesOfRooms { get; set; }
        public IDbSet<LocalizedAttribute> LocalizedAttributes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(typeof(EntityConfigurationWithSchemaName<>).Assembly);


            //modelBuilder.Configurations.Add(ConfigurationFactory.Create<UserConfiguration>());
            //modelBuilder.Configurations.Add(ConfigurationFactory.Create<MembershipConfiguration>());
            //modelBuilder.Configurations.Add(ConfigurationFactory.Create<UserLoginConfiguration>());

            //modelBuilder.Configurations.Add(ConfigurationFactory.Create<RegionConfiguration>());

            //modelBuilder.Configurations.Add(ConfigurationFactory.Create<CountryConfiguration>());

            //modelBuilder.Configurations.Add(ConfigurationFactory.Create<LanguageConfiguration>());

            //modelBuilder.Configurations.Add(ConfigurationFactory.Create<LocalizedRegionConfiguration>());

            ////For Database namespace Property (dbo.TypesOfAccommodations => Property.TypesOfAccommodations)
            //modelBuilder.Configurations.Add(ConfigurationFactory.Create<TypeOfAccommodationConfiguration>());

            //modelBuilder.Configurations.Add(ConfigurationFactory.Create<LocalizedTypeOfAccommodationConfiguration>());

            ////For Database namespace Property (dbo.Accommodations => Property.Accommodations)
            //modelBuilder.Configurations.Add(ConfigurationFactory.Create<AccommodationConfiguration>());

            //modelBuilder.Configurations.Add(ConfigurationFactory.Create<LocalizedAccommodationConfiguration>());

            ////For Database namespace Property (dbo.TypesOfDescriptions => Property.TypesOfDescriptions)
            //modelBuilder.Configurations.Add(ConfigurationFactory.Create<TypeOfDescriptionConfiguration>());

            //modelBuilder.Configurations.Add(ConfigurationFactory.Create<LocalizedDescriptionOfAccommodationConfiguration>());

            ////For Database namespace Property (dbo.Captions => Property.Captions)
            //modelBuilder.Configurations.Add(ConfigurationFactory.Create<CaptionConfiguration>());

            //modelBuilder.Configurations.Add(ConfigurationFactory.Create<LocalizedCaptionConfiguration>());

            ////For Database namespace Property (dbo.TypesOfRooms => Property.TypesOfRooms)
            //modelBuilder.Configurations.Add(ConfigurationFactory.Create<TypeOfRoomConfiguration>());

            //modelBuilder.Configurations.Add(ConfigurationFactory.Create<LocalizedTypeOfRoomConfiguration>());

            ////EntityType 'AccommodationToAttribute' has no key defined. Define the key for this EntityType.AccommodationToAttributes
            //modelBuilder.Configurations.Add(ConfigurationFactory.Create<AccommodationToAttributeConfiguration>());

            ////For Database namespace Property (dbo.Attributes => Property.Attributes)
            //modelBuilder.Configurations.Add(ConfigurationFactory.Create<AttributeConfiguration>());

            //modelBuilder.Configurations.Add(ConfigurationFactory.Create<LocalizedAttributeConfiguration>());


        }
    }
}