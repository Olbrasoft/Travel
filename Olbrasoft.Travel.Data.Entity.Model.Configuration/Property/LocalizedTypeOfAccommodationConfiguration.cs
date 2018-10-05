using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Property
{
    public class LocalizedTypeOfAccommodationConfiguration : LocalizedConfiguration<LocalizedTypeOfAccommodation>
    {
        public LocalizedTypeOfAccommodationConfiguration()
        {
            ToTable("LocalizedTypesOfAccommodations");

            Property(p => p.Name).HasMaxLength(256).IsRequired();

            HasRequired(p => p.Language).WithMany(p => p.LocalizedTypesOfAccommodations).WillCascadeOnDelete(false);

            HasRequired(p => p.Creator).WithMany(user => user.LocalizedTypesOfAccommodations).WillCascadeOnDelete(false);

            HasRequired(p => p.TypeOfAccommodation).WithMany(toa => toa.LocalizedTypesOfAccommodations).WillCascadeOnDelete(true);
        }
    }
}