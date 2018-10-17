using Olbrasoft.Travel.Data.Entity.Model.Geography;
using Olbrasoft.Travel.Data.Repository.Geography;

namespace Olbrasoft.Travel.Data.Entity.Repository.Geography
{
    public class RegionsToTypesRepository : ManyToManyRepository<RegionToType>, IRegionsToTypesRepository
    {
        public RegionsToTypesRepository(GeographyDatabaseContext context) : base(context)
        {
        }
    }
}