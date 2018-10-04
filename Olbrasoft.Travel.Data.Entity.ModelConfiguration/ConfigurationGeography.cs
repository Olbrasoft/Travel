using System.Data.Entity.ModelConfiguration;

namespace Olbrasoft.Travel.Data.Entity.ModelConfiguration
{
    public abstract class ConfigurationGeography<TEntity> : ConfigurationWithSchemaName<TEntity> where TEntity : class
    {
        protected ConfigurationGeography() : base("geo")
        {
        }

        protected new EntityTypeConfiguration<TEntity> ToTable(string tableName)
        {
            return ToTable(tableName, SchemaName);
        }
    }
}