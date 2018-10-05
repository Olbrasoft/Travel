using System.Collections.Generic;

namespace Olbrasoft.Travel.Data.Entity.Model.Property
{
    public class TypeOfAttribute : BaseName
    {
        public ICollection<Attribute> Attributes { get; set; }
    }
}
