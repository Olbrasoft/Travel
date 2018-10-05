

using Olbrasoft.Travel.Data.Entity.Model.Geography;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Geography
{
    public class CountryConfiguration : GeographyConfiguration<Country>
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