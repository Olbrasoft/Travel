﻿using System.Collections.Generic;
using Olbrasoft.Data.Repository.Bulk;
using Olbrasoft.Travel.Data.Entity.Model;

namespace Olbrasoft.Travel.Data.Repository.Property
{
    public interface IMappedPropertiesRepository<T> : IRepository<T>, IBaseRepository<T> where T : class, IHaveEanId<int>
    {
        HashSet<int> EanIds { get; }
        IReadOnlyDictionary<int, int> EanIdsToIds { get; }
    }
}