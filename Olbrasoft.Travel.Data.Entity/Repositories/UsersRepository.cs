using System.Data.Entity;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.DataAccessLayer;

namespace Olbrasoft.Travel.Data.Entity.Repositories
{
    public class UsersRepository : BaseRepository<User>, IUsersRepository
    {
        //protected readonly TravelContext Context;

        public UsersRepository(DbContext context) : base(context)
        {
        }

        public User AddIfNotExist(User user)
        {
            var userIn = user;
            var storedUser = Find(u => u.Id == userIn.Id || u.UserName == userIn.UserName);

            if (storedUser == null)
            {
                Add(user);
            }
            else
            {
                user = storedUser;
            }

            return user;
        }
    }
}