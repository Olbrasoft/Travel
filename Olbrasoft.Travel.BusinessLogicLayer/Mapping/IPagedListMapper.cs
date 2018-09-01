using Olbrasoft.Pagination.Collections.Generic;

namespace Olbrasoft.Travel.BusinessLogicLayer.Mapping
{
    public interface IPagedListMapper<in TSource, out TDestination> 
    {
        IPagedList<TDestination> Map(IPagedList<TSource> source);
    }
}