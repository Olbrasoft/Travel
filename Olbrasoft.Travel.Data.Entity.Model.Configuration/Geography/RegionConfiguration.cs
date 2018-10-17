using Olbrasoft.Travel.Data.Entity.Model.Geography;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Geography
{
    public class RegionConfiguration : GeographyConfiguration<Region>
    {
        public RegionConfiguration()
        {
            ToTable("Regions").HasIndex(p => p.EanId).IsUnique();

            HasRequired(r => r.Creator).WithMany(u => u.Regions).WillCascadeOnDelete(false);

            HasOptional(p => p.AdditionalCountryProperties).WithRequired(country => country.Region).WillCascadeOnDelete(true);
            HasOptional(p => p.AdditionalAirportProperties).WithRequired(p => p.Region).WillCascadeOnDelete(true);
        }
    }
}