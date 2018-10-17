using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Property
{
    public class TypeOfAccommodationConfiguration : PropertyConfiguration<TypeOfAccommodation>
    {
        public TypeOfAccommodationConfiguration()
        {
            ToTable("TypesOfAccommodations");
            HasIndex(toa => toa.EanId).IsUnique();
        }
    }
}