using System.Data.Entity;

namespace Olbrasoft.Data.Entity
{
    public abstract class DbContextWithInjectionConfigurationFactory : DbContext
    {
        protected IFactory ConfigurationFactory { get; }

        protected DbContextWithInjectionConfigurationFactory(IFactory configurationFactory, string nameOrConnectionString) : base(nameOrConnectionString)
        {
            ConfigurationFactory = configurationFactory;
        }
    }
}