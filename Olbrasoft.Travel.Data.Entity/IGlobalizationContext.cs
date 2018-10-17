using Olbrasoft.Travel.Data.Entity.Model.Globalization;
using Olbrasoft.Travel.Data.Entity.Model.Property;
using System.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity
{
    public interface IGlobalizationContext : ITravelContext
    {
        IDbSet<Language> Languages { get; set; }
        IDbSet<LocalizedRegion> LocalizedRegions { get; set; }
        IDbSet<LocalizedTypeOfAccommodation> LocalizedTypesOfAccommodations { get; set; }
        IDbSet<LocalizedAccommodation> LocalizedAccommodations { get; set; }
        IDbSet<LocalizedDescriptionOfAccommodation> LocalizedDescriptionsOfAccommodations { get; set; }
        IDbSet<LocalizedCaption> LocalizedCaptions { get; set; }
        IDbSet<LocalizedTypeOfRoom> LocalizedTypesOfRooms { get; set; }
        IDbSet<LocalizedAttribute> LocalizedAttributes { get; set; }
        IDbSet<AccommodationToAttribute> AccommodationsToAttributes { get; set; }
    }
}