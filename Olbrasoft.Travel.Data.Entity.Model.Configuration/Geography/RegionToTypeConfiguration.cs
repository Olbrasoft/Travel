using Olbrasoft.Travel.Data.Entity.Model.Geography;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Geography
{
    public class RegionToTypeConfiguration : GeographyConfiguration<RegionToType>
    {
        public RegionToTypeConfiguration()
        {
            ToTable("RegionsToTypes");

            HasKey(p => new { p.Id, p.ToId });

            HasRequired(rtp => rtp.Region).WithMany(region => region.RegionsToTypes).WillCascadeOnDelete(true);

            HasRequired(regionToType => regionToType.Creator).WithMany(user => user.RegionsToTypes).WillCascadeOnDelete(false);

            HasRequired(regionToType => regionToType.TypeOfRegion).WithMany(typeOfRegion => typeOfRegion.RegionsToTypes).HasForeignKey(p => p.ToId).WillCascadeOnDelete(false);
        }
    }
}