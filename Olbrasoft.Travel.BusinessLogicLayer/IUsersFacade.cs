using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.BusinessLogicLayer
{
    public interface IUsersFacade : ITravelFacade<User>
    {
        void AddIfNotExist(ref User user);
    }
}