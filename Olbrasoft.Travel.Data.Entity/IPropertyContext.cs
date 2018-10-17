using Olbrasoft.Travel.Data.Entity.Model.Property;
using System.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity
{
    public interface IPropertyContext : ITravelContext
    {
        IDbSet<TypeOfAccommodation> TypesOfAccommodations { get; set; }
        IDbSet<Chain> Chains { get; set; }
        IDbSet<Model.Property.Accommodation> Accommodations { get; set; }
        IDbSet<TypeOfDescription> TypesOfDescriptions { get; set; }
        IDbSet<Caption> Captions { get; set; }
        IDbSet<PhotoOfAccommodation> PhotosOfAccommodations { get; set; }
        IDbSet<TypeOfRoom> TypesOfRooms { get; set; }
        IDbSet<PhotoOfAccommodationToTypeOfRoom> PhotosOfAccommodationsToTypesOfRooms { get; set; }
        IDbSet<TypeOfAttribute> TypesOfAttributes { get; set; }
        IDbSet<SubTypeOfAttribute> SubTypesOfAttributes { get; set; }
        IDbSet<Attribute> Attributes { get; set; }
   
    }
}