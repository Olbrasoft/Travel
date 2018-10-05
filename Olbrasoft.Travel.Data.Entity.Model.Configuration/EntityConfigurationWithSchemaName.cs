using System.Data.Entity.ModelConfiguration;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration
{
    public abstract class EntityConfigurationWithSchemaName<TEntity> : EntityTypeConfiguration<TEntity> where TEntity : class
    {
        protected string SchemaName { get; }

        protected EntityConfigurationWithSchemaName(string schemaName)
        {
            SchemaName = schemaName;
        }
    }
}