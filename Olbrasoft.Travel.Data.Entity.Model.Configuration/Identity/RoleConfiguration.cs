using Olbrasoft.Travel.Data.Entity.Model.Identity;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Identity
{
    public class RoleConfiguration : IdentityConfiguration<Role>
    {
        public RoleConfiguration()
        {
            ToTable("Roles");
            Property(p => p.Name).HasMaxLength(256).IsRequired();
            HasIndex(p => p.Name).HasName("RoleNameIndex").IsUnique();
            HasMany(r => r.Users).WithRequired().HasForeignKey(ur => ur.RoleId);
        }
    }
}