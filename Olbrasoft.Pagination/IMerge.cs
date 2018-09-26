﻿using System.Collections.Generic;

namespace Olbrasoft.Pagination
{
    public interface IMerge<T, in T1>
    {
        IResultWithTotalCount<T> Merge(IResultWithTotalCount<T> master, IEnumerable<T1> slave);
    }
}