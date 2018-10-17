using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Spatial;
using Olbrasoft.Travel.Data.Entity.Model.Globalization;

namespace Olbrasoft.Travel.Data.Entity.Model.Geography
{
    public class Region : OwnerCreatorIdAndCreator
    {
        public Region()
        {
            RegionsToTypes = new HashSet<RegionToType>();
            LocalizedRegions = new HashSet<LocalizedRegion>();
        }

        public DbGeography Coordinates { get; set; }

        public DbGeography CenterCoordinates { get; set; }

        public long EanId { get; set; } = long.MinValue;

        public ICollection<RegionToType> RegionsToTypes { get; set; }
        
        public ICollection<RegionToRegion> ToParentRegions { get; set; }

        public ICollection<RegionToRegion> ToChildRegions { get; set; }

        public ICollection<LocalizedRegion> LocalizedRegions { get; set; }

        public Country AdditionalCountryProperties { get; set; }

        public Airport AdditionalAirportProperties { get; set; }
    }
}