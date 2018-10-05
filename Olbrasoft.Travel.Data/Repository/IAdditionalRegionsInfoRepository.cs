using System.Collections.Generic;
using Olbrasoft.Data.Repository.Bulk;
using Olbrasoft.Travel.Data.Entity.Model;

namespace Olbrasoft.Travel.Data.Repository
{
    public interface IAdditionalRegionsInfoRepository<T> : IBaseRepository<T>, IRepository<T>
        where T : CreatorInfo, IAdditionalRegionInfo
    {
        IReadOnlyDictionary<string, int> CodesToIds { get; }
    }
}