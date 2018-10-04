using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Entity.ModelConfiguration
{
    public class TypeOfRegionConfiguration : ConfigurationGeography<TypeOfRegion>
    {
        public TypeOfRegionConfiguration()
        {
            ToTable("TypesOfRegions");
            HasIndex(typeOfRegion => typeOfRegion.Name).IsUnique();
        }
    }
}