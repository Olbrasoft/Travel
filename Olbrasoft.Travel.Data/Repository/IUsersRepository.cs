using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Repository
{
    public interface IUsersRepository : IBaseRepository<User>
    {
        User AddIfNotExist(User user);
    }
}