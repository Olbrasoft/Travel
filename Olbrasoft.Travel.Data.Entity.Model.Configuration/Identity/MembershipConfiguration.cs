using Olbrasoft.Travel.Data.Entity.Model.Identity;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Identity
{
    public class MembershipConfiguration : IdentityConfiguration<Membership>
    {
        public MembershipConfiguration()
        {
            ToTable("Memberships");
            HasKey(p => new { p.UserId, p.RoleId });
        }
    }
}