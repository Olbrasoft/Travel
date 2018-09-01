using System.Collections.Generic;

namespace Olbrasoft.Travel.Data.Entities
{
    public class SubTypeOfAttribute : BaseName
    {
        public ICollection<Attribute> Attributes { get; set; }
    }
}