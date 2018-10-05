using System.Data.Entity.ModelConfiguration;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration
{
    public abstract class GeographyConfiguration<TEntity> : EntityConfigurationWithSchemaName<TEntity> where TEntity : class
    {
        protected GeographyConfiguration() : base("geo")
        {
        }

        protected new EntityTypeConfiguration<TEntity> ToTable(string tableName)
        {
            return ToTable(tableName, SchemaName);
        }
    }
}