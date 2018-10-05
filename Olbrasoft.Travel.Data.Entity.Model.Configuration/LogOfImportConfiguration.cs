

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration
{
    public class LogOfImportConfiguration : CreationInfoConfiguration<LogOfImport>
    {
        public LogOfImportConfiguration()
        {
            ToTable("LogsOfImports");
            Property(p => p.Log).HasMaxLength(255).IsRequired();
        }
    }
}