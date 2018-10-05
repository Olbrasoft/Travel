using System.Data.Entity.ModelConfiguration;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Property
{
    public abstract class PropertyConfiguration<TEntity> : EntityConfigurationWithSchemaName<TEntity> where TEntity : class
    {
        protected PropertyConfiguration() : base("acco")
        {
        }

        protected new EntityTypeConfiguration<TEntity> ToTable(string tableName)
        {
            return ToTable(tableName, SchemaName);
        }
    }
}