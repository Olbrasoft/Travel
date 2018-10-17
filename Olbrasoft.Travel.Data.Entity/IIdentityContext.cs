using System.Data.Entity;
using Olbrasoft.Travel.Data.Entity.Model.Identity;

namespace Olbrasoft.Travel.Data.Entity
{
    public interface IIdentityContext
    {
        IDbSet<User> Users { get; set; }
        IDbSet<Role> Roles { get; set; }
    }
}