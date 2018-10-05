

using Olbrasoft.Travel.Data.Entity.Model;

namespace Olbrasoft.Travel.Business.Facades
{
    public interface IUsersFacade : ITravelFacade<User>
    {
        void AddIfNotExist(ref User user);
    }
}