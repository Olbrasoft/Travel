using Olbrasoft.Travel.Data.Entity.Model.Configuration.Geography;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Identity;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Property;
using Olbrasoft.Travel.Data.Entity.Model.Property;
using System.Data.Entity;
using Olbrasoft.Travel.Data.Entity.Model.Configuration;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Globalization;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Routing;
using UserConfiguration = Olbrasoft.Travel.Data.Entity.Model.Configuration.Identity.UserConfiguration;

namespace Olbrasoft.Travel.Data.Entity
{
    public class PropertyDatabaseContext : TravelDatabaseContext, IPropertyContext
    {
        public IDbSet<TypeOfAccommodation> TypesOfAccommodations { get; set; }
        public IDbSet<Chain> Chains { get; set; }
        public IDbSet<Model.Property.Accommodation> Accommodations { get; set; }
        public IDbSet<TypeOfDescription> TypesOfDescriptions { get; set; }
        public IDbSet<Caption> Captions { get; set; }
        public IDbSet<PhotoOfAccommodation> PhotosOfAccommodations { get; set; }
        public IDbSet<TypeOfRoom> TypesOfRooms { get; set; }
        public IDbSet<PhotoOfAccommodationToTypeOfRoom> PhotosOfAccommodationsToTypesOfRooms { get; set; }
        public IDbSet<TypeOfAttribute> TypesOfAttributes { get; set; }
        public IDbSet<SubTypeOfAttribute> SubTypesOfAttributes { get; set; }
        public IDbSet<Attribute> Attributes { get; set; }
      
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)


        //{

        //    modelBuilder.Configurations.AddFromAssembly(typeof(EntityConfigurationWithSchemaName<>).Assembly);

        //    //modelBuilder.Configurations.Add(ConfigurationFactory.Create<UserConfiguration>());
        //    //modelBuilder.Configurations.Add(ConfigurationFactory.Create<MembershipConfiguration>());
        //    //modelBuilder.Configurations.Add(ConfigurationFactory.Create<UserLoginConfiguration>());

        //    //modelBuilder.Configurations.Add(ConfigurationFactory.Create<RegionConfiguration>());
        //    //modelBuilder.Configurations.Add(ConfigurationFactory.Create<AirportConfiguration>());
        //    //modelBuilder.Configurations.Add(ConfigurationFactory.Create<CountryConfiguration>());

        //    //modelBuilder.Configurations.Add(ConfigurationFactory.Create<TypeOfAccommodationConfiguration>());
        //    //modelBuilder.Configurations.Add(ConfigurationFactory.Create<ChainConfiguration>());
        //    //modelBuilder.Configurations.Add(ConfigurationFactory.Create<AccommodationConfiguration>());

        //    //modelBuilder.Configurations.Add(ConfigurationFactory.Create<TypeOfDescriptionConfiguration>());

        //    //modelBuilder.Configurations.Add(ConfigurationFactory.Create<LocalizedDescriptionOfAccommodationConfiguration>());

        //    //modelBuilder.Configurations.Add(ConfigurationFactory.Create<PathToPhotoConfiguration>());
        //    //modelBuilder.Configurations.Add(ConfigurationFactory.Create<FileExtensionConfiguration>());

        //    //modelBuilder.Configurations.Add(ConfigurationFactory.Create<CaptionConfiguration>());

        //    //modelBuilder.Configurations.Add(ConfigurationFactory.Create<PhotoOfAccommodationConfiguration>());

        //    //modelBuilder.Configurations.Add(ConfigurationFactory.Create<TypeOfRoomConfiguration>());

        //    //modelBuilder.Configurations.Add(ConfigurationFactory.Create<PhotoOfAccommodationToTypeOfRoomConfiguration>());

        //    //modelBuilder.Configurations.Add(ConfigurationFactory.Create<TypeOfAttributeConfiguration>());

        //    //modelBuilder.Configurations.Add(ConfigurationFactory.Create<SubTypeOfAttributeConfiguration>());

        //    //modelBuilder.Configurations.Add(ConfigurationFactory.Create<AttributeConfiguration>());

        //    ////For Database Namespace Globalization (dbo.Languages => Globalization.Languages)
        //    //modelBuilder.Configurations.Add(ConfigurationFactory.Create<LanguageConfiguration>());

        //    //modelBuilder.Configurations.Add(ConfigurationFactory.Create<AccommodationToAttributeConfiguration>());

        //}
    }
}