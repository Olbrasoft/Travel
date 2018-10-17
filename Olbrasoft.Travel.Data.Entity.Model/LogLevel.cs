using System.Collections.Generic;
using Olbrasoft.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity.Model
{
    public class LogLevel : OwnerCreatorIdAndCreator, IHaveName, IHaveDescription
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Log> Logs { get; set; }
    }
}