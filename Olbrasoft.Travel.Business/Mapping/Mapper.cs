using AutoMapper;

namespace Olbrasoft.Travel.Business.Mapping
{
    public class Mapper<TSource, TDestination> : IMapper<TSource, TDestination>
    {
        protected AutoMapper.IMapper AutoMapper { get; }

        public Mapper(IMapper autoMapper)
        {
            AutoMapper = autoMapper;
        }

        public TDestination Map(TSource source)
        {
            return AutoMapper.Map<TDestination>(source);
        }
    }
}