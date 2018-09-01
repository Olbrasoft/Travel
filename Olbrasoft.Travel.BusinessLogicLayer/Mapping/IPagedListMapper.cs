using Olbrasoft.Shared.Collections.Generic;

namespace Olbrasoft.Travel.BusinessLogicLayer.Mapping
{
    public interface IPagedEnumerableMapper<in TSource, out TDestination> 
    {
        IPagedList<TDestination> Map(IPagedList<TSource> source);
    }
}