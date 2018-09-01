using Olbrasoft.Travel.Data.Entities;
using System.Collections.Generic;

namespace Olbrasoft.Travel.DataAccessLayer
{
    public interface IAdditionalRegionsInfoRepository<T> : IBaseRepository<T>, IBulkRepository<T>
        where T : CreatorInfo, IAdditionalRegionInfo
    {
        IReadOnlyDictionary<string, int> CodesToIds { get; }
    }
}