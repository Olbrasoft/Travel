using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Entity.ModelConfiguration
{
    public class AirportConfiguration : ConfigurationGeography<Airport>
    {
        public AirportConfiguration()
        {
            ToTable("Airports");

            HasIndex(c => c.Id).IsUnique();
            HasIndex(c => c.Code).IsUnique();

            Property(p => p.Code).HasMaxLength(3).IsRequired();

            HasRequired(c => c.Creator).WithMany(user => user.Airports).WillCascadeOnDelete(false);
            HasRequired(c => c.Region).WithOptional(r => r.AdditionalAirportProperties).WillCascadeOnDelete(true);
        }
    }
}