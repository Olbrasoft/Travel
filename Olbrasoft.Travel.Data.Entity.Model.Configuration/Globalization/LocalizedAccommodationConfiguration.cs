using Olbrasoft.Travel.Data.Entity.Model.Globalization;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Globalization
{
    public class LocalizedAccommodationConfiguration : LocalizedConfiguration<LocalizedAccommodation>
    {
        public LocalizedAccommodationConfiguration()
        {
            ToTable("LocalizedAccommodations");

            Property(localizedAccommodation => localizedAccommodation.Location).HasMaxLength(80);

            Property(localizedAccommodation => localizedAccommodation.CheckInTime).HasMaxLength(10);

            Property(localizedAccommodation => localizedAccommodation.CheckOutTime).HasMaxLength(10);

            Property(localizedAccommodation => localizedAccommodation.Name).HasMaxLength(70).IsRequired();

            HasRequired(localizedAccommodation => localizedAccommodation.Language).WithMany(l => l.LocalizedAccommodations).WillCascadeOnDelete(false);

          //  HasRequired(la => la.Accommodation).WithMany(a => a.LocalizedAccommodations).WillCascadeOnDelete(true);

            HasRequired(localizedAccommodation => localizedAccommodation.Creator).WithMany(user => user.LocalizedAccommodations).WillCascadeOnDelete(false);
        }
    }
}