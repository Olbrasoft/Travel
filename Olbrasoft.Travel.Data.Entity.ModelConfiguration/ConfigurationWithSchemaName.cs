using System.Data.Entity.ModelConfiguration;

namespace Olbrasoft.Travel.Data.Entity.ModelConfiguration
{
    public abstract class ConfigurationWithSchemaName<TEntity> : EntityTypeConfiguration<TEntity> where TEntity : class
    {
        protected string SchemaName { get; }

        protected ConfigurationWithSchemaName(string schemaName)
        {
            SchemaName = schemaName;
        }
    }
}