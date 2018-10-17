namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Identity
{
    public class UserConfiguration : IdentityConfiguration<Model.Identity.User>
    {
        public UserConfiguration()
        {
            ToTable("Users");

            Property(user => user.Email).HasMaxLength(256);

            Property(user => user.UserName).HasMaxLength(256).IsRequired();

            HasIndex(user => user.UserName).HasName("UserNameIndex").IsUnique();

            HasMany(user => user.Roles).WithRequired().HasForeignKey(ur => ur.UserId);

            HasMany(user => user.Claims).WithRequired().HasForeignKey(uc => uc.UserId);

            HasMany(user => user.Logins).WithRequired().HasForeignKey(ul => ul.UserId);

        }
    }
}