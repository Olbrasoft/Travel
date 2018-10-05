using System.Data.Entity;
using Olbrasoft.Travel.Data.Entity.Model.Geography;
using Olbrasoft.Travel.Data.Repository;


namespace Olbrasoft.Travel.Data.Entity.Repositories
{
    public class RegionsToTypesRepository : ManyToManyRepository<RegionToType>, IRegionsToTypesRepository
    {
        public RegionsToTypesRepository(DbContext context) : base(context)
        {
        }
    }
}