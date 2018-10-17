using Olbrasoft.Travel.Data.Entity.Model.Geography;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Geography
{
    public class AirportConfiguration : GeographyConfiguration<Airport>
    {
        public AirportConfiguration()
        {
            ToTable("Airports");

            HasIndex(c => c.Id).IsUnique();

            HasIndex(c => c.Code).IsUnique();

            Property(p => p.Code).HasMaxLength(3).IsRequired();

            HasRequired(c => c.Creator).WithMany(user => user.Airports).WillCascadeOnDelete(false);
        }
    }
}