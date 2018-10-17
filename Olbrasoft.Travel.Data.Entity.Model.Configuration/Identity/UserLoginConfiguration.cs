using Olbrasoft.Travel.Data.Entity.Model.Identity;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Identity
{
    public class UserLoginConfiguration : IdentityConfiguration<UserLogin>
    {
        public UserLoginConfiguration()
        {
            ToTable("UsersLogins");
            HasKey(l => new
            {
                l.LoginProvider,
                l.ProviderKey,
                l.UserId
            });
        }
    }
}