using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Entity.ModelConfiguration
{
    public class CountryConfiguration : ConfigurationGeography<Country>
    {
        public CountryConfiguration()
        {
            ToTable("Countries");

            Property(p => p.Code).HasMaxLength(2).IsRequired();

            HasRequired(c => c.Creator)
                .WithMany(user => user.Countries).WillCascadeOnDelete(false);

            HasIndex(c => c.Id).IsUnique();
            HasIndex(c => c.Code).IsUnique();

            HasRequired(c => c.Region).WithOptional(r => r.AdditionalCountryProperties).WillCascadeOnDelete(true);
        }
    }
}