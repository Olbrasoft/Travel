using Olbrasoft.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration
{
    public abstract class GlobalizationConfiguration<TEntity> : EntityConfigurationWithSchemaName<TEntity> where TEntity : class, IHaveDateTimeOfCreation
    {
        protected GlobalizationConfiguration() : base("Globalization")
        {
        }
    }
}