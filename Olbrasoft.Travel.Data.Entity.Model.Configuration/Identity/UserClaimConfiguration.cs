using Olbrasoft.Travel.Data.Entity.Model.Identity;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Identity
{
    public class UserClaimConfiguration :IdentityConfiguration<UserClaim>
    {
        public UserClaimConfiguration()
        {
            ToTable("UsersClaims");

        }
    }
}