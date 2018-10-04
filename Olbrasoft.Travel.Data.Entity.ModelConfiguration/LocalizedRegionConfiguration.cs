using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Entity.ModelConfiguration
{
    public class LocalizedRegionConfiguration : ConfigurationGeography<LocalizedRegion>
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