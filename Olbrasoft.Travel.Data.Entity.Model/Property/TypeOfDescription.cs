using System.Collections.Generic;

namespace Olbrasoft.Travel.Data.Entity.Model.Property
{
    public class TypeOfDescription : BaseName
    {
        public virtual ICollection<Description> Descriptions { get; set; }
    }
}