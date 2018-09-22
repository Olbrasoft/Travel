using Olbrasoft.Travel.Data.Entities;
using System.Collections.Generic;
using Olbrasoft.Data.Repository.Bulk;

namespace Olbrasoft.Travel.Data.Repository
{
    public interface IMappedEntitiesRepository<T> : IRepository<T>, IBaseRepository<T> where T : class, IHaveEanId<int>
    {
        HashSet<int> EanIds { get; }
        IReadOnlyDictionary<int, int> EanIdsToIds { get; }
    }
}