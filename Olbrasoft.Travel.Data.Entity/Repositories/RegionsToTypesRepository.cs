using System.Data.Entity;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.DataAccessLayer;

namespace Olbrasoft.Travel.Data.Entity.Repositories
{
    public class RegionsToTypesRepository : ManyToManyRepository<RegionToType>, IRegionsToTypesRepository
    {
        public RegionsToTypesRepository(DbContext context) : base(context)
        {
        }
    }
}