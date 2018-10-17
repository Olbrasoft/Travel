using System.Collections.Generic;
using Olbrasoft.Travel.Data.Entity.Model.Geography;


namespace Olbrasoft.Travel.Data.Entity.Model
{
    public interface IAdditionalRegionInfo
    {
        string Code { get; set; }
        Region Region { get; set; }
       // ICollection<Property.Accommodation> Accommodations { get; set; }
    }
}