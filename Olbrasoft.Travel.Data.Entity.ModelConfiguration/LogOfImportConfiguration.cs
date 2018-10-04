using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Entity.ModelConfiguration
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