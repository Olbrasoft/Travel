using Olbrasoft.Travel.Data.Entities;
using System.Collections.Generic;
using Olbrasoft.Data.Repository.Bulk;

namespace Olbrasoft.Travel.Data.Repository
{
    public interface IPathsToPhotosRepository : IRepository<PathToPhoto>, IBaseRepository<PathToPhoto>
    {
        IReadOnlyDictionary<string, int> PathsToIds { get; }
        HashSet<string> Paths { get; }
    }
}