using System.Collections.Generic;

namespace Olbrasoft.Travel.Data.Entity.Model.Geography
{
    public class TypeOfRegion : BaseName
    {
       public ICollection<RegionToType> RegionsToTypes { get; set; }
    }
}