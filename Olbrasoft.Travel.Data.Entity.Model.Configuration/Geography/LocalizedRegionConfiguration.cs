

using Olbrasoft.Travel.Data.Entity.Model.Geography;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Geography
{
    public class LocalizedRegionConfiguration : GeographyConfiguration<LocalizedRegion>
    {
        public LocalizedRegionConfiguration()
        {
            ToTable("LocalizedRegions");

            Property(p => p.Name).HasMaxLength(255).IsRequired();

            Property(p => p.LongName).HasMaxLength(510);

            HasRequired(lr => lr.Creator).WithMany(user => user.LocalizedRegions).WillCascadeOnDelete(false);

            HasRequired(lr => lr.Language).WithMany(l => l.LocalizedRegions).WillCascadeOnDelete(false);
        }
    }
}