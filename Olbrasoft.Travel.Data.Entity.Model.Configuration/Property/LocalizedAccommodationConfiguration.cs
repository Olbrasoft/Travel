using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Property
{
    public class LocalizedAccommodationConfiguration : LocalizedConfiguration<LocalizedAccommodation>
    {
        public LocalizedAccommodationConfiguration()
        {
            ToTable("LocalizedAccommodations");

            Property(p => p.Location).HasMaxLength(80);

            Property(p => p.CheckInTime).HasMaxLength(10);

            Property(p => p.CheckOutTime).HasMaxLength(10);

            Property(p => p.Name).HasMaxLength(70).IsRequired();

            HasRequired(p => p.Language).WithMany(l => l.LocalizedAccommodations).WillCascadeOnDelete(false);

            HasRequired(la => la.Accommodation).WithMany(a => a.LocalizedAccommodations).WillCascadeOnDelete(true);

            HasRequired(la => la.Creator).WithMany(user => user.LocalizedAccommodations).WillCascadeOnDelete(false);
        }
    }
}