using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Property
{
    public class LocalizedAttributeConfiguration : Configuration.Property.LocalizedConfiguration<LocalizedAttribute>
    {
        public LocalizedAttributeConfiguration()
        {
            ToTable("LocalizedAttributes");

            Property(p => p.Description).HasMaxLength(255).IsRequired();

            HasRequired(la => la.Creator).WithMany(user => user.LocalizedAttributes).WillCascadeOnDelete(false);

            HasRequired(la => la.Language).WithMany(l => l.LocalizedAttributes).WillCascadeOnDelete(false);
        }
    }
}