using System.Collections.Generic;
using Olbrasoft.Data.Repository.Bulk;
using Olbrasoft.Travel.Data.Entity.Model;

namespace Olbrasoft.Travel.Data.Repository
{
    public interface IPathsToPhotosRepository : IRepository<PathToPhoto>, IBaseRepository<PathToPhoto>
    {
        IReadOnlyDictionary<string, int> PathsToIds { get; }
        HashSet<string> Paths { get; }
    }
}