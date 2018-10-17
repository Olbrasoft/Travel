
namespace Olbrasoft.Travel.Data.Entity.Model.Dbo.Configuration
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