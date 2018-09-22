using System.Collections.Generic;
using Olbrasoft.Data.Repository.Bulk;

namespace Olbrasoft.Travel.Data.Repository
{
    public interface ITypesRepository<T> : SharpRepository.Repository.IRepository<T>, IRepository<T> where T : class
    {
        int GetId(string name);

        IEnumerable<string> Names { get; }
        IReadOnlyDictionary<string, int> NamesToIds { get; }
    }
}