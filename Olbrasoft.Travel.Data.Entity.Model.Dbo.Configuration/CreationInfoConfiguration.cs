using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Olbrasoft.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity.Model.Dbo.Configuration
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