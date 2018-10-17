using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Globalization
{
    public class AccommodationToAttributeConfiguration : GlobalizationConfiguration<AccommodationToAttribute>
    {
        public AccommodationToAttributeConfiguration()
        {
            ToTable("AccommodationsToAttributes");

            HasKey(p => new { p.AccommodationId, p.AttributeId, p.LanguageId });

            Property(p => p.Text).HasMaxLength(800);

            HasRequired(ata => ata.Creator).WithMany(u => u.AccommodationsToAttributes).WillCascadeOnDelete(false);

            HasRequired(ata => ata.Language).WithMany(l => l.AccommodationsToAttributes).WillCascadeOnDelete(false);

            HasRequired(ata => ata.Attribute).WithMany(a => a.AccommodationsToAttributes).WillCascadeOnDelete(false);
        }
    }
}