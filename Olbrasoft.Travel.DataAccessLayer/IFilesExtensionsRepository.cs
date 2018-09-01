using Olbrasoft.Travel.Data.Entities;
using System.Collections.Generic;

namespace Olbrasoft.Travel.DataAccessLayer
{
    public interface IFilesExtensionsRepository : IBaseRepository<FileExtension>
    {
        HashSet<string> Extensions { get; }
        IReadOnlyDictionary<string, int> ExtensionsToIds { get; }

        void Save(IEnumerable<FileExtension> filesExtensions);
    }
}