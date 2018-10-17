using Olbrasoft.Data.Repository.Bulk;
using System.Collections.Generic;
using Olbrasoft.Data.Entity;

namespace Olbrasoft.Travel.Data.Repository
{
    public interface IOfName<T> : SharpRepository.Repository.IRepository<T>, IRepository<T> where T : class, IHaveName
    {
        int GetId(string name);
        IEnumerable<string> Names { get; }
        IReadOnlyDictionary<string, int> NamesToIds { get; }
    }
}