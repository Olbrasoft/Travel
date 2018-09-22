﻿using Olbrasoft.Data.Repository.Bulk;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Repository
{
    public interface ILocalizedRepository<T> : IRepository<T>, IBaseRepository<T, int, int>
        where T : Localized
    {
        //bool Exists(int languageId);
        //IEnumerable<int> FindIds(int languageId);
    }
}