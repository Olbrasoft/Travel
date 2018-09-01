using System.Collections.Generic;

namespace Olbrasoft.Travel.Data.Entities
{
    public class TypeOfAttribute : BaseName
    {
        public ICollection<Attribute> Attributes { get; set; }
    }
}
