using AutoMapper;

namespace Olbrasoft.Travel.Data.Mapping
{
    public class Mapper : IMap
    {
        private readonly IConfigurationProvider _configurationProvider;

        public Mapper(IConfigurationProvider configurationProvider)
        {
            _configurationProvider = configurationProvider;
        }

        public T Map<T>(object source)
        {
            return _configurationProvider.CreateMapper().Map<T>(source);

        }
    }
}