using Olbrasoft.Travel.Data.Entities;
using System.Collections.Generic;
using Olbrasoft.Data.Repository.Bulk;

namespace Olbrasoft.Travel.Data.Repository
{
    public interface IRegionsRepository : IRepository<Region>, IBaseRepository<Region>
    {
        IReadOnlyDictionary<long, int> EanIdsToIds { get; }
    }
}