using Olbrasoft.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity.Model
{
    public class OwnerCreatorIdAndCreator : HaveCreatorId<int, int>
    {
        public new Identity.User Creator { get; set; }
    }
}