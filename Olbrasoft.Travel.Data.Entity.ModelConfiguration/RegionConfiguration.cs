using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Entity.ModelConfiguration
{
    public class RegionConfiguration : ConfigurationGeography<Region>
    {
        public RegionConfiguration()
        {
            ToTable("Regions").HasIndex(p => p.EanId).IsUnique();

            HasRequired(r => r.Creator).WithMany(u => u.Regions).WillCascadeOnDelete(false);
        }
    }
}