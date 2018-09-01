using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.DataAccessLayer
{
    public interface IUsersRepository : IBaseRepository<User>
    {
        User AddIfNotExist(User user);
    }
}