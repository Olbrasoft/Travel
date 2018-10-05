using Olbrasoft.Travel.Data.Entity.Model;

namespace Olbrasoft.Travel.Data.Repository
{
    public interface IUsersRepository : IBaseRepository<User>
    {
        User AddIfNotExist(User user);
    }
}