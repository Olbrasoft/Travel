using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Business.Facades
{
    public interface IUsersFacade : ITravelFacade<User>
    {
        void AddIfNotExist(ref User user);
    }
}