using Olbrasoft.Travel.Data.Entity.Model.Geography;
using System.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity
{
    public class GeographyDatabaseContext : TravelDatabaseContext, IGeographyContext
    {
        public IDbSet<TypeOfRegion> TypesOfRegions { get; set; }
        public IDbSet<Region> Regions { get; set; }
        public IDbSet<SubClass> SubClasses { get; set; }
        public IDbSet<RegionToType> RegionsToTypes { get; set; }
        public IDbSet<RegionToRegion> RegionsToRegions { get; set; }
        public IDbSet<Country> Countries { get; set; }
        public IDbSet<Airport> Airports { get; set; }
    }
}