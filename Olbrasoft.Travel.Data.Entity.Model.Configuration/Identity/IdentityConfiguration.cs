using Olbrasoft.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Identity
{
    public abstract class IdentityConfiguration<TEntity> : EntityConfigurationWithSchemaName<TEntity> where TEntity : class, IHaveDateTimeOfCreation
    {
        protected IdentityConfiguration() : base("Identity")
        {
        }
    }
}