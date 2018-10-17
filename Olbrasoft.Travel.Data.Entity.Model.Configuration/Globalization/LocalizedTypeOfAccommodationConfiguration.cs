using Olbrasoft.Travel.Data.Entity.Model.Globalization;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Globalization
{
    public class LocalizedTypeOfAccommodationConfiguration : LocalizedConfiguration<LocalizedTypeOfAccommodation>
    {
        public LocalizedTypeOfAccommodationConfiguration()
        {
            ToTable("LocalizedTypesOfAccommodations");

            Property(p => p.Name).HasMaxLength(256).IsRequired();

            HasRequired(p => p.Creator).WithMany(user => user.LocalizedTypesOfAccommodations).WillCascadeOnDelete(false);

            HasRequired(p => p.Language).WithMany(language => language.LocalizedTypesOfAccommodations).WillCascadeOnDelete(false);
        }
    }
}