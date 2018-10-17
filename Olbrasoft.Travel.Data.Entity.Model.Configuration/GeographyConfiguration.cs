using System.Data.Entity.ModelConfiguration;
using Olbrasoft.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration
{
    public abstract class GeographyConfiguration<TEntity> : EntityConfigurationWithSchemaName<TEntity> where TEntity : class, IHaveDateTimeOfCreation
    {
        protected GeographyConfiguration() : base("Geography")
        {
        }
    }
}