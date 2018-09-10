﻿using Olbrasoft.Pagination.Collections.Generic;

namespace Olbrasoft.Travel.Business.Mapping
{
    public interface IMapper<in TSource>
    {
        TDestination Map<TDestination>(TSource source);
        IPagedList<TDestination> Map<TDestination>(IPagedList<TSource> source);
    }
}