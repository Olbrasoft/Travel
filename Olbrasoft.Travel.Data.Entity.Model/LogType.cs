using Olbrasoft.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity.Model
{
    public class LogType : OwnerCreatorIdAndCreator, IHaveName
    {
        public string Name { get; set; }
    }
}