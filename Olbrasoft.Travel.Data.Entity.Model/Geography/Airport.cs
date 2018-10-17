using Olbrasoft.Travel.Data.Entity.Model.Property;
using System.Collections.Generic;

namespace Olbrasoft.Travel.Data.Entity.Model.Geography
{
    public class Airport : OwnerCreatorIdAndCreator, IAdditionalRegionInfo
    {
        public string Code { get; set; }

        public Region Region { get; set; }

        public ICollection<Accommodation> Accommodations { get; set; }
    }
}