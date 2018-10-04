using System.Collections.Generic;

namespace Olbrasoft.Travel.Data.Entities
{
    public class Country : CreatorInfo, IAdditionalRegionInfo
    {
        //todo change https://en.wikipedia.org/wiki/ISO_3166-1

        public string Code { get; set; }

        public virtual Region Region { get; set; }

        public virtual ICollection<Accommodation> Accommodations { get; set; }
    }
}