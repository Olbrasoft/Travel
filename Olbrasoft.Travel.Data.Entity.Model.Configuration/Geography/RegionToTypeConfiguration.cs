

using Olbrasoft.Travel.Data.Entity.Model.Geography;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Geography
{
    public class RegionToTypeConfiguration : GeographyConfiguration<RegionToType>
    {
        public RegionToTypeConfiguration()
        {
            ToTable("RegionsToTypes").HasRequired(rtp => rtp.Creator).WithMany(user => user.RegionsToTypes)
                .WillCascadeOnDelete(false);

            HasKey(p => new { p.Id, p.ToId });

            HasRequired(rtp => rtp.Region).WithMany(region => region.RegionsToTypes).WillCascadeOnDelete(true);

            HasRequired(rtt => rtt.TypeOfRegion).WithMany(tor => tor.RegionsToTypes)
                .HasForeignKey(p => p.ToId).WillCascadeOnDelete(false);
        }
    }
}