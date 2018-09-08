﻿namespace Olbrasoft.Travel.Business.Mapping
{
    public interface IMapper<in TSource,out TDestination>
    {
        TDestination Map(TSource source);
    }
}