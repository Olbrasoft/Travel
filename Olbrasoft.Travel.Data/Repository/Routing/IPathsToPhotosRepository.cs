using Olbrasoft.Data.Repository.Bulk;
using Olbrasoft.Travel.Data.Entity.Model.Routing;
using System.Collections.Generic;

namespace Olbrasoft.Travel.Data.Repository.Routing
{
    public interface IPathsToPhotosRepository : IRepository<PathToPhoto>, IBaseRepository<PathToPhoto>
    {
        IReadOnlyDictionary<string, int> PathsToIds { get; }
        HashSet<string> Paths { get; }
    }
}