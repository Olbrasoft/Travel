using Olbrasoft.Travel.Data.Entity.Model.Geography;
using System.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity
{
    public interface IGeographyContext
    {
        IDbSet<TypeOfRegion> TypesOfRegions { get; set; }
        IDbSet<Region> Regions { get; set; }
        IDbSet<SubClass> SubClasses { get; set; }
        IDbSet<RegionToType> RegionsToTypes { get; set; }
        IDbSet<RegionToRegion> RegionsToRegions { get; set; }
        IDbSet<Country> Countries { get; set; }
        IDbSet<Airport> Airports { get; set; }
    }
}