namespace Olbrasoft.Travel.Data.Entity.Model.Configuration
{
    public class LocalizedCaptionConfiguration : LocalizedConfiguration<LocalizedCaption>
    {
        public LocalizedCaptionConfiguration()
        {
            HasRequired(lc => lc.Language).WithMany(l => l.LocalizedCaptions).WillCascadeOnDelete(false);

            HasRequired(lc => lc.Creator).WithMany(u => u.LocalizedCaptions)
                .WillCascadeOnDelete(false);
        }
    }
}