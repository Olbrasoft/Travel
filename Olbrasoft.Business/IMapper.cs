using Olbrasoft.Pagination.Collections.Generic;

namespace Olbrasoft.Business
{
    public interface IMapper<in TSource>
    {
        TDestination Map<TDestination>(TSource source);
        IPagedList<TDestination> Map<TDestination>(IPagedList<TSource> source);
    }
}
