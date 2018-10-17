namespace Olbrasoft.Travel.Data.Entity.Model.Dbo.Configuration
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