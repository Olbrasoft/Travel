using Olbrasoft.Pagination.Collections.Generic;

namespace Olbrasoft.Travel.Business.Mapping
{
    public interface IMapper<in TSource,out TDestination>
    {
        TDestination Map(TSource source);
        IPagedList<TDestination> Map(IPagedList<TSource> source);

    }
}