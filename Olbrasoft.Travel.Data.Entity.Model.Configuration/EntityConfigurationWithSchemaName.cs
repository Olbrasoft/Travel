using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Olbrasoft.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration
{
    public abstract class EntityConfigurationWithSchemaName<TEntity> : EntityTypeConfiguration<TEntity> where TEntity : class, IHaveDateTimeOfCreation
    {
        protected string SchemaName { get; }

        protected EntityConfigurationWithSchemaName(string schemaName)
        {
            SchemaName = schemaName;
            Property(entity => entity.DateAndTimeOfCreation).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
        }

        protected new EntityTypeConfiguration<TEntity> ToTable(string tableName)
        {
            return ToTable(tableName, SchemaName);
        }
    }
}