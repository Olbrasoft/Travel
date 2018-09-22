using Olbrasoft.Travel.Data.Entities;
using System;
using System.Collections.Generic;
using Olbrasoft.Data.Repository.Bulk;

namespace Olbrasoft.Travel.Data.Repository
{
    public interface IPhotosOfAccommodationsRepository : IRepository<PhotoOfAccommodation>,
        IBaseRepository<PhotoOfAccommodation>
    {
        IReadOnlyDictionary<Tuple<int, string, int>, int> GetPathIdsAndFileIdsAndExtensionIdsToIds();

        //IReadOnlyDictionary<Tuple<int, string, int>, int> GetPathIdsAndFileIdsAndExtensionIdsToIds(
        //    IEnumerable<int> pathIds);
    }
}