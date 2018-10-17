using Olbrasoft.Travel.Data.Entity.Model.Globalization;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Globalization
{
    public class LocalizedRegionConfiguration : GlobalizationConfiguration<LocalizedRegion>
    {
        public LocalizedRegionConfiguration()
        {
            ToTable("LocalizedRegions");

            HasKey(p => new {p.Id, p.LanguageId});

            Property(p => p.Name).HasMaxLength(255).IsRequired();

            Property(p => p.LongName).HasMaxLength(510);
            
            HasRequired(lr=>lr.Region).WithMany(r=>r.LocalizedRegions).WillCascadeOnDelete(true);

            HasRequired(lr => lr.Language).WithMany(l => l.LocalizedRegions).WillCascadeOnDelete(false);

            HasRequired(lr => lr.Creator).WithMany(user => user.LocalizedRegions).WillCascadeOnDelete(false);
        }
    }
}