namespace Olbrasoft.Travel.Data.Entity.Model.Configuration
{
    public class LogTypeConfiguration:CreatorConfiguration<LogType>
    {
        public LogTypeConfiguration()
        {
            ToTable("LogTypes");
            Property(p => p.Name).HasMaxLength(255).IsRequired();
        }
    }
}