using System.Data.Entity.ModelConfiguration;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Properties
{
    public class PropertyConfiguration<TEntity> : EntityConfigurationWithSchemaName<TEntity> where TEntity : class
    {
        public PropertyConfiguration() : base("acco")
        {
        }

        protected new EntityTypeConfiguration<TEntity> ToTable(string tableName)
        {
            return ToTable(tableName, SchemaName);
        }
    }
}