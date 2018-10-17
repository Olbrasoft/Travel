using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration
{
    public class LogLevelConfiguration : EntityTypeConfiguration<LogLevel>
    {
        public LogLevelConfiguration()
        {
            HasKey(p => p.Id);
            ToTable("LogLevels");
            HasIndex(p => p.Name).IsUnique();
            Property(p => p.Description).HasMaxLength(250);
            Property(p => p.Name).HasMaxLength(50).IsRequired();
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
           // HasRequired(p=>p.Creator).WithMany(u => u.LogLevels).WillCascadeOnDelete(true);
        }
    }
}