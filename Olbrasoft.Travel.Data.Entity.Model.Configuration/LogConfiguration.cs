namespace Olbrasoft.Travel.Data.Entity.Model.Configuration
{
    public class LogConfiguration : CreationInfoConfiguration<Log>
    {
        public LogConfiguration()
        {
            ToTable("Logs");
            Property(p => p.Text).HasMaxLength(255).IsRequired();
            //HasRequired(log => log.Creator).WithMany(user => user.Logs).WillCascadeOnDelete(false);
            HasRequired(log=>log.Level).WithMany(logLevel=>logLevel.Logs).WillCascadeOnDelete(true);
        }
    }
}