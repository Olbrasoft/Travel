

using Olbrasoft.Travel.Data.Entity.Model;
using Olbrasoft.Travel.Data.Entity.Model.Identity;

namespace Olbrasoft.Travel.Business.Facades
{
    public interface IUsersFacade : ITravelFacade<User>
    {
        void AddIfNotExist(ref User user);
    }
}