using Olbrasoft.Travel.Data.Entity.Model.Geography;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Geography
{
    public class RegionToRegionConfiguration : GeographyConfiguration<RegionToRegion>
    {
        public RegionToRegionConfiguration()
        {
            ToTable("RegionsToRegions");

            HasKey(p => new {p.Id, p.ToId});

            HasRequired(rtr => rtr.Creator).WithMany(u => u.RegionsToRegions).WillCascadeOnDelete(false);

            HasRequired(regionToRegion => regionToRegion.Region)
                .WithMany(region => region.ToChildRegions)
                .HasForeignKey(regionToRegion => regionToRegion.Id)
                .WillCascadeOnDelete(false);

            HasRequired(regionToRegion => regionToRegion.ParentRegion)
                .WithMany(region => region.ToParentRegions)
                .HasForeignKey(regionToRegion => regionToRegion.ToId)
                .WillCascadeOnDelete(true);
        }
    }
}