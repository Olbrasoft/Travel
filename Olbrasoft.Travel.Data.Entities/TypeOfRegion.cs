using System.Collections.Generic;

namespace Olbrasoft.Travel.Data.Entities
{
    public class TypeOfRegion : BaseName
    {
        public ICollection<RegionToType> RegionsToTypes { get; set; }
    }
}