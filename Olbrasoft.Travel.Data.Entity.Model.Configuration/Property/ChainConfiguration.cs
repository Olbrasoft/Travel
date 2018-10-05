using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Property
{
    public class ChainConfiguration : CreatorConfiguration<Chain>
    {
        public ChainConfiguration()
        {
            ToTable("Chains");

            HasIndex(p => p.EanId).IsUnique();

            Property(p => p.Name).HasMaxLength(30).IsRequired();

            HasRequired(ch => ch.Creator).WithMany(user => user.Chains).WillCascadeOnDelete(true);
        }
    }
}