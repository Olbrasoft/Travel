using Olbrasoft.Data.Entity;
using System;
using System.Collections.Generic;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Globalization
{
    public class Language : OwnerCreatorIdAndCreator
    {
        public string EanLanguageCode { get; set; }
      
        public virtual ICollection<LocalizedRegion> LocalizedRegions { get; set; }

        public virtual ICollection<LocalizedTypeOfAccommodation> LocalizedTypesOfAccommodations { get; set; }

        public virtual ICollection<LocalizedAccommodation> LocalizedAccommodations { get; set; }

        public virtual ICollection<LocalizedDescriptionOfAccommodation> LocalizedDescriptionsOfAccommodations { get; set; }

        public virtual ICollection<LocalizedCaption> LocalizedCaptions { get; set; }

        public virtual ICollection<LocalizedTypeOfRoom> LocalizedTypesOfRooms { get; set; }

        public virtual ICollection<LocalizedAttribute> LocalizedAttributes { get; set; }

        public virtual ICollection<AccommodationToAttribute> AccommodationsToAttributes { get; set; }
    }
}