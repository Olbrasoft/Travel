using Olbrasoft.Travel.Data.Entity.Model.Geography;
using Olbrasoft.Travel.Data.Entity.Model.Property;
using System.Collections.Generic;

namespace Olbrasoft.Travel.Data.Entity.Model
{
    public class Language : CreatorInfo
    {
        public string EanLanguageCode { get; set; }

        public virtual ICollection<LocalizedRegion> LocalizedRegions { get; set; }

        public virtual ICollection<LocalizedTypeOfAccommodation> LocalizedTypesOfAccommodations { get; set; }

        public virtual ICollection<LocalizedAccommodation> LocalizedAccommodations { get; set; }

        public virtual ICollection<Description> Descriptions { get; set; }

        public virtual ICollection<LocalizedCaption> LocalizedCaptions { get; set; }

        public virtual ICollection<LocalizedTypeOfRoom> LocalizedTypesOfRooms { get; set; }

        public virtual ICollection<LocalizedAttribute> LocalizedAttributes { get; set; }

        public virtual ICollection<AccommodationToAttribute> AccommodationsToAttributes { get; set; }
    }
}