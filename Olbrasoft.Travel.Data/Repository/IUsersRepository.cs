using System.Net.Configuration;
using Olbrasoft.Travel.Data.Entity.Model;
using User = Olbrasoft.Travel.Data.Entity.Model;

namespace Olbrasoft.Travel.Data.Repository
{
    public interface IUsersRepository : IBaseRepository<Olbrasoft.Travel.Data.Entity.Model.Identity.User>
    {
        Olbrasoft.Travel.Data.Entity.Model.Identity.User AddIfNotExist(Olbrasoft.Travel.Data.Entity.Model.Identity.User user);
    }
}