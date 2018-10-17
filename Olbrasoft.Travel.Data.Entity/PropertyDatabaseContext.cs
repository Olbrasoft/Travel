using Olbrasoft.Travel.Data.Entity.Model.Property;
using System.Data.Entity;

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
    }
}