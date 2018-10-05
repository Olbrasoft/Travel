

using Olbrasoft.Travel.Data.Entity.Model.Geography;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Geography
{
    public class TypeOfRegionConfiguration : NameConfiguration<TypeOfRegion>
    {
        public TypeOfRegionConfiguration()
        {
            ToTable("TypesOfRegions");
            HasIndex(typeOfRegion => typeOfRegion.Name).IsUnique();
        }
    }
}