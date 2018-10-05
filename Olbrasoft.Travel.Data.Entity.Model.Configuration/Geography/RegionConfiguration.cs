

using Olbrasoft.Travel.Data.Entity.Model.Geography;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Geography
{
    public class RegionConfiguration : GeographyConfiguration<Region>
    {
        public RegionConfiguration()
        {
            ToTable("Regions").HasIndex(p => p.EanId).IsUnique();

            HasRequired(r => r.Creator).WithMany(u => u.Regions).WillCascadeOnDelete(false);
        }
    }
}