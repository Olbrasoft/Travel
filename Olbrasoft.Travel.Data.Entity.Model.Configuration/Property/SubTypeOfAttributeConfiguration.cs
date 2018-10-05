using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Property
{
    public class SubTypeOfAttributeConfiguration : NameConfiguration<SubTypeOfAttribute>
    {
        public SubTypeOfAttributeConfiguration()
        {
            ToTable("SubTypesOfAttributes");

            HasIndex(p => p.Name).IsUnique();
        }
    }
}