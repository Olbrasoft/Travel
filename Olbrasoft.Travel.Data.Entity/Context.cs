using Olbrasoft.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity
{
    internal abstract class Context : DbContextWithInjectionConfigurationFactory
    {
        protected Context(IFactory configurationFactory) :  base(configurationFactory, "name=TravelDatabaseContext")
        {
        }
    }
}
