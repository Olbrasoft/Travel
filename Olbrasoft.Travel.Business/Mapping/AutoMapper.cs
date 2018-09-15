using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using Olbrasoft.Business;
using Olbrasoft.Collections.Generic;
using Olbrasoft.Pagination;

namespace Olbrasoft.Travel.Business.Mapping
{
    public class AutoMapper<TSource> : IMapper<TSource>
    {
        protected IMapper Mapper { get; }

        public AutoMapper(IMapper mapper)
        {
            Mapper = mapper;
        }

        public TDestination Map<TDestination>(TSource source)
        {
            return Mapper.Map<TDestination>(source);
        }

        public IPagedList<TDestination> Map<TDestination>(IPagedList<TSource> source)
        {
            var destinations = Mapper.Map<IEnumerable<TDestination>>(source.AsEnumerable());

            return destinations.ToPagedList(source.AsPagination());
        }
    }
}