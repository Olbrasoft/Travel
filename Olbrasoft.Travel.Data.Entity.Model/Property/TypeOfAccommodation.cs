using System.Collections.Generic;

namespace Olbrasoft.Travel.Data.Entity.Model.Property
{
    public class TypeOfAccommodation : CreatorInfo, IHaveEanId<int>
    {
        public int EanId { get; set; } = int.MinValue;

        public virtual ICollection<LocalizedTypeOfAccommodation> LocalizedTypesOfAccommodations { get; set; }

        public virtual ICollection<Property.Accommodation> Accommodations { get; set; }
    }
}