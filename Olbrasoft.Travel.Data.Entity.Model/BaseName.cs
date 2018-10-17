using Olbrasoft.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity.Model
{
    public class BaseName : OwnerCreatorIdAndCreator, IHaveName
    {
        public string Name { get; set; }
    }
}