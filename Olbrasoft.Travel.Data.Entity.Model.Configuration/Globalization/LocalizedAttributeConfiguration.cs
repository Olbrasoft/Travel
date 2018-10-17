using Olbrasoft.Travel.Data.Entity.Model.Globalization;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Globalization
{
    public class LocalizedAttributeConfiguration : LocalizedConfiguration<LocalizedAttribute>
    {
        public LocalizedAttributeConfiguration()
        {
            ToTable("LocalizedAttributes");

            Property(p => p.Description).HasMaxLength(255).IsRequired();
            
            HasRequired(la => la.Language).WithMany(l => l.LocalizedAttributes).WillCascadeOnDelete(false);

            HasRequired(la => la.Creator).WithMany(user => user.LocalizedAttributes).WillCascadeOnDelete(false);
        }
    }
}