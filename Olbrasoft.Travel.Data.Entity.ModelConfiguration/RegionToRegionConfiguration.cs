using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Entity.ModelConfiguration
{
    public class RegionToRegionConfiguration :ConfigurationGeography<RegionToRegion>
    {
        public RegionToRegionConfiguration()
        {
            ToTable("RegionsToRegions");

            HasRequired(rtr => rtr.Creator)
                .WithMany(u => u.RegionsToRegions).WillCascadeOnDelete(false);

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