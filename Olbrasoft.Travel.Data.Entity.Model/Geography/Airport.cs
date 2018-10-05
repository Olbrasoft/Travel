using System.Collections.Generic;
using Olbrasoft.Travel.Data.Entity.Model;
using Olbrasoft.Travel.Data.Entity.Model.Geography;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Geography
{
    public class Airport : CreatorInfo, IAdditionalRegionInfo
    {
       
        public string Code { get; set; }

        public Region Region { get; set; }

        public ICollection<Accommodation> Accommodations { get; set; }
    }
}