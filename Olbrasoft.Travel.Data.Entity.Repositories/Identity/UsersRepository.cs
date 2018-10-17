using Olbrasoft.Travel.Data.Repository;

namespace Olbrasoft.Travel.Data.Entity.Repositories.Identity
{
    public class UsersRepository : IdentityRepository<Model.Identity.User>, IUsersRepository
    {
        public Model.Identity.User AddIfNotExist(Model.Identity.User user)
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

        public UsersRepository(IdentityDatabaseContext context) : base(context)
        {
        }
    }
}