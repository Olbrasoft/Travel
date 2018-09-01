﻿using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.DataAccessLayer
{
    public interface ILocalizedRepository<T> : IBulkRepository<T>, IBaseRepository<T, int, int>
        where T : Localized
    {
        //bool Exists(int languageId);
        //IEnumerable<int> FindIds(int languageId);
    }
}