using Olbrasoft.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration
{
    public abstract class RoutingConfiguration<TEntity> : EntityConfigurationWithSchemaName<TEntity> where TEntity : class, IHaveDateTimeOfCreation
    {
        protected RoutingConfiguration() : base("Routing")
        {
        }
    }
}