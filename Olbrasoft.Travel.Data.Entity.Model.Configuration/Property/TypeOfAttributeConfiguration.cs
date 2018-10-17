using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Property
{
    public class TypeOfAttributeConfiguration : NameConfiguration<TypeOfAttribute>
    {
        public TypeOfAttributeConfiguration()
        {
            ToTable("TypesOfAttributes");
            HasIndex(p => p.Name).IsUnique();
        }
    }
}