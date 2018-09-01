using Olbrasoft.Travel.Data.Entities;
using System.Collections.Generic;

namespace Olbrasoft.Travel.DataAccessLayer
{
    public interface IRegionsRepository : IBulkRepository<Region>, IBaseRepository<Region>
    {
        IReadOnlyDictionary<long, int> EanIdsToIds { get; }
    }
}