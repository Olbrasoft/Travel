using System.Collections.Generic;

namespace Olbrasoft.Travel.Data.Entities
{
    public class TypeOfDescription : BaseName
    {
        public virtual ICollection<Description> Descriptions { get; set; }
    }
}