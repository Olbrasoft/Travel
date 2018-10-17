using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Property
{
    public class AccommodationConfiguration : CreatorConfiguration<Accommodation>
    {
        public AccommodationConfiguration()
        {
            ToTable("Accommodations");

            HasIndex(accommodation => accommodation.EanId).IsUnique();

            Property(accommodation => accommodation.CenterCoordinates).IsRequired();

            Property(accommodation => accommodation.AdditionalAddress).HasMaxLength(50);

            Property(accommodation => accommodation.Address).HasMaxLength(50).IsRequired();

            HasRequired(accommodation => accommodation.Creator).WithMany(user => user.Accommodations).WillCascadeOnDelete(false);

            HasRequired(accommodation => accommodation.Country).WithMany(country => country.Accommodations).WillCascadeOnDelete(false);
        }
    }
}