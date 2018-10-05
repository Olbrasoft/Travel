using Olbrasoft.Travel.Data.Entity.Model;
using Olbrasoft.Travel.Data.Entity.Model.Configuration;
using Olbrasoft.Travel.Data.Entity.Model.Geography;
using Olbrasoft.Travel.Data.Entity.Model.Property;
using System.Data.Entity;
using Attribute = Olbrasoft.Travel.Data.Entity.Model.Property.Attribute;

namespace Olbrasoft.Travel.Data.Entity
{
    public class TravelContext : DbContext, ITravelContext
    {
        public virtual IDbSet<User> Users { get; set; }
        public virtual IDbSet<LogOfImport> LogsOfImports { get; set; }
        public virtual IDbSet<TypeOfRegion> TypesOfRegions { get; set; }
        public virtual IDbSet<Region> Regions { get; set; }
        public virtual IDbSet<SubClass> SubClasses { get; set; }
        public virtual IDbSet<Language> Languages { get; set; }
        public virtual IDbSet<RegionToType> RegionsToTypes { get; set; }
        public virtual IDbSet<LocalizedRegion> LocalizedRegions { get; set; }
        public virtual IDbSet<RegionToRegion> RegionsToRegions { get; set; }
        public virtual IDbSet<Country> Countries { get; set; }
        public virtual IDbSet<Airport> Airports { get; set; }
        public virtual IDbSet<TypeOfAccommodation> TypesOfAccommodations { get; set; }
        public virtual IDbSet<LocalizedTypeOfAccommodation> LocalizedTypesOfAccommodations { get; set; }
        public virtual IDbSet<Chain> Chains { get; set; }
        public virtual IDbSet<Model.Property.Accommodation> Accommodations { get; set; }
        public virtual IDbSet<LocalizedAccommodation> LocalizedAccommodations { get; set; }
        public virtual IDbSet<TypeOfDescription> TypesOfDescriptions { get; set; }
        public virtual IDbSet<Description> Descriptions { get; set; }
        public virtual IDbSet<PathToPhoto> PathsToPhotos { get; set; }
        public virtual IDbSet<FileExtension> FilesExtensions { get; set; }
        public virtual IDbSet<Caption> Captions { get; set; }
        public virtual IDbSet<LocalizedCaption> LocalizedCaptions { get; set; }
        public virtual IDbSet<PhotoOfAccommodation> PhotosOfAccommodations { get; set; }
        public virtual IDbSet<TypeOfRoom> TypesOfRooms { get; set; }
        public virtual IDbSet<LocalizedTypeOfRoom> LocalizedTypesOfRooms { get; set; }
        public virtual IDbSet<PhotoOfAccommodationToTypeOfRoom> PhotosOfAccommodationsToTypesOfRooms { get; set; }
        public virtual IDbSet<TypeOfAttribute> TypesOfAttributes { get; set; }
        public virtual IDbSet<SubTypeOfAttribute> SubTypesOfAttributes { get; set; }
        public virtual IDbSet<Attribute> Attributes { get; set; }
        public virtual IDbSet<LocalizedAttribute> LocalizedAttributes { get; set; }
        public virtual IDbSet<AccommodationToAttribute> AccommodationsToAttributes { get; set; }

        public TravelContext() : base("name=Travel")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(typeof(CreationInfoConfiguration<>).Assembly);
        }
    }
}