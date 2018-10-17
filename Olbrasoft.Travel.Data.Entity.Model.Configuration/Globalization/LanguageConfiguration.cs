using Olbrasoft.Travel.Data.Entity.Model.Globalization;
using System.ComponentModel.DataAnnotations.Schema;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Globalization
{
    public class LanguageConfiguration : GlobalizationConfiguration<Language>
    {
        public LanguageConfiguration()
        {
            ToTable("Languages");

            HasKey(p => p.Id);

            HasIndex(p => p.EanLanguageCode).IsUnique();

            HasRequired(l => l.Creator).WithMany(u => u.Languages);

            Property(p => p.EanLanguageCode).HasMaxLength(5).IsRequired();

            Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(e => e.DateAndTimeOfCreation).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
        }
    }
}