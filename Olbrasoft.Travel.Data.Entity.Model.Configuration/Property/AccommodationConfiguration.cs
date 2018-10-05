using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Property
{
    public class AccommodationConfiguration : CreatorConfiguration<Accommodation>
    {
        public AccommodationConfiguration()
        {
            ToTable("Accommodations");

            HasIndex(e => e.EanId).IsUnique();

            Property(p => p.CenterCoordinates).IsRequired();

            Property(p => p.AdditionalAddress).HasMaxLength(50);

            Property(p => p.Address).HasMaxLength(50).IsRequired();

            HasRequired(a => a.TypeOfAccommodation).WithMany(toa => toa.Accommodations).WillCascadeOnDelete(true);

            HasRequired(a => a.Creator).WithMany(user => user.Accommodations).WillCascadeOnDelete(false);

            HasRequired(a => a.Country).WithMany(c => c.Accommodations).WillCascadeOnDelete(false);
        }
    }
}