using System.ComponentModel.DataAnnotations.Schema;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Property
{
    public class AccommodationToAttributeConfiguration : PropertyConfiguration<AccommodationToAttribute>
    {
        public AccommodationToAttributeConfiguration()
        {
            ToTable("AccommodationsToAttributes");

            HasKey(p => new {p.AccommodationId, p.AttributeId, p.LanguageId});

            Property(p => p.Text).HasMaxLength(800);

            Property(p => p.DateAndTimeOfCreation).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

            HasRequired(ata => ata.Attribute).WithMany(a => a.AccommodationsToAttributes).WillCascadeOnDelete(false);

            HasRequired(ata => ata.Language).WithMany(l => l.AccommodationsToAttributes).WillCascadeOnDelete(false);

            HasRequired(ata => ata.Creator).WithMany(u => u.AccommodationsToAttributes).WillCascadeOnDelete(false);
        }
    }
}