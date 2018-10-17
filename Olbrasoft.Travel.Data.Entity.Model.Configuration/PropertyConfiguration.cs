using Olbrasoft.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration
{
    public abstract class PropertyConfiguration<TEntity> : EntityConfigurationWithSchemaName<TEntity> where TEntity : class, IHaveDateTimeOfCreation
    {
        protected PropertyConfiguration() : base("Property")
        {
        }
    }
}