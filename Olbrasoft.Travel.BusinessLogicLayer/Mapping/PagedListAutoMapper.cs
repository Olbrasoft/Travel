using System.Collections.Generic;
using System.Linq;
using Olbrasoft.Pagination.Collections.Generic;
using Olbrasoft.Pagination.Linq;

namespace Olbrasoft.Travel.BusinessLogicLayer.Mapping
{
    public class PagedListAutoMapper<TSource, TDestination> : IPagedListMapper<TSource, TDestination>
    {
        protected AutoMapper.IMapper Mapper { get; }

        public PagedListAutoMapper(AutoMapper.IMapper mapper )
        {
            Mapper = mapper;
        }

        public IPagedList<TDestination> Map(IPagedList<TSource> source)
        {

            var enumerable = Mapper.Map<IEnumerable<TDestination>>(source.AsEnumerable());

            return enumerable.AsPagedList(source.AsPagination());
            
        }
    }
}