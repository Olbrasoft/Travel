using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Entity.ModelConfiguration
{
    public class UserConfiguration : CreationInfoConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("Users").HasIndex(p => p.UserName).IsUnique();
            Property(p => p.UserName).IsRequired().HasMaxLength(255);
        }
    }
}