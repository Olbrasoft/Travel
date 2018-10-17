using Olbrasoft.Travel.Data.Entity.Model.Globalization;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Globalization
{
    public class LocalizedCaptionConfiguration : LocalizedConfiguration<LocalizedCaption>
    {
        public LocalizedCaptionConfiguration()
        {
            ToTable("LocalizedCaptions");

            Property(lc => lc.Text).HasMaxLength(255).IsRequired();

            HasRequired(lc => lc.Language).WithMany(l => l.LocalizedCaptions).WillCascadeOnDelete(false);

            HasRequired(lc => lc.Creator).WithMany(u => u.LocalizedCaptions).WillCascadeOnDelete(false);
        }
    }
}