using System.Collections.Generic;
using Olbrasoft.Travel.Data.Entity.Model.Globalization;

namespace Olbrasoft.Travel.Data.Entity.Model.Property
{
    public class TypeOfAccommodation : OwnerCreatorIdAndCreator, IHaveEanId<int>
    {
        public int EanId { get; set; } = int.MinValue;

       public virtual ICollection<LocalizedTypeOfAccommodation> LocalizedTypesOfAccommodations { get; set; }

       public virtual ICollection<Accommodation> Accommodations { get; set; }
    }
}