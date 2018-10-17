using Olbrasoft.Travel.Data.Entity.Model.Routing;
using System.Collections.Generic;

namespace Olbrasoft.Travel.Data.Repository.Routing
{
    public interface IFilesExtensionsRepository : IBaseRepository<FileExtension>
    {
        HashSet<string> Extensions { get; }
        IReadOnlyDictionary<string, int> ExtensionsToIds { get; }

        void Save(IEnumerable<FileExtension> filesExtensions);
    }
}