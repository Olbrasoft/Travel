using System.Collections.Generic;
using System.Linq;
using Olbrasoft.Shared.Collections.Generic;
using Olbrasoft.Shared.Linq;

namespace Olbrasoft.Travel.BusinessLogicLayer.Mapping
{
    public class PagedEnumerableAutoMapper<TSource, TDestination> : IPagedEnumerableMapper<TSource, TDestination>
    {
        protected AutoMapper.IMapper Mapper { get; }

        public PagedEnumerableAutoMapper(AutoMapper.IMapper mapper )
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