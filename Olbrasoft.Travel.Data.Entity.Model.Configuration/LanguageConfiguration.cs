using System.ComponentModel.DataAnnotations.Schema;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration
{
    public class LanguageConfiguration : CreatorConfiguration<Language>
    {
        public LanguageConfiguration()
        {
            ToTable("Languages");

            HasIndex(p => p.EanLanguageCode).IsUnique();

            Property(p => p.EanLanguageCode).HasMaxLength(5);

            HasRequired(l => l.Creator).WithMany(u => u.Languages);

            Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(e => e.DateAndTimeOfCreation).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
        }
    }
}