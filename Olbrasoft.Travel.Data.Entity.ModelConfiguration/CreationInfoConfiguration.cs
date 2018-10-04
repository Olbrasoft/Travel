using Olbrasoft.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Olbrasoft.Travel.Data.Entity.ModelConfiguration
{
    public abstract class CreationInfoConfiguration<TEntity> : EntityTypeConfiguration<TEntity> where TEntity : CreationInfo<int>
    {
        protected CreationInfoConfiguration()
        {
            HasKey(p => p.Id);
            Property(p => p.DateAndTimeOfCreation).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
        }
    }
}