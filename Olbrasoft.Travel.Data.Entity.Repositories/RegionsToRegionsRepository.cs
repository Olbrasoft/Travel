using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Repository;


namespace Olbrasoft.Travel.Data.Entity.Repositories
{
    public class RegionsToRegionsRepository : ManyToManyRepository<RegionToRegion>, IRegionsToRegionsRepository
    {
        public RegionsToRegionsRepository(TravelContext context) : base(context)
        {

        }
    }
}