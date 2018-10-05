using System.Data.Entity.ModelConfiguration;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration
{
    public class LocalizedConfiguration<TEntity> : EntityTypeConfiguration<TEntity> where TEntity : Localized
    {
        public LocalizedConfiguration()
        {
            HasKey(p => new { p.Id, p.LanguageId });
        }
    }
}