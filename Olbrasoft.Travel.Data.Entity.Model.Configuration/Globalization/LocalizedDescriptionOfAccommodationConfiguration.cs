using Olbrasoft.Travel.Data.Entity.Model.Globalization;
using System.ComponentModel.DataAnnotations.Schema;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Globalization
{
    public class LocalizedDescriptionOfAccommodationConfiguration : GlobalizationConfiguration<LocalizedDescriptionOfAccommodation>
    {
        public LocalizedDescriptionOfAccommodationConfiguration()
        {
            ToTable("LocalizedDescriptionsOfAccommodations");

            Property(p => p.Text).IsRequired();

            HasKey(p => new { p.AccommodationId, p.TypeOfDescriptionId, p.LanguageId });

            Property(p => p.DateAndTimeOfCreation).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

            HasRequired(d => d.Creator).WithMany(u => u.LocalizedDescriptionsOfAccommodations).WillCascadeOnDelete(false);

            HasRequired(d => d.Language).WithMany(l => l.LocalizedDescriptionsOfAccommodations).WillCascadeOnDelete(false);

            HasRequired(d => d.TypeOfDescription).WithMany(tod => tod.LocalizedDescriptionsOfAccommodations).WillCascadeOnDelete(false);
        }
    }
}