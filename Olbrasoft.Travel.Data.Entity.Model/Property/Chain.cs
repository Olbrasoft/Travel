using Olbrasoft.Data.Entity;
using System.Collections.Generic;

namespace Olbrasoft.Travel.Data.Entity.Model.Property
{
    public class Chain : CreatorInfo, IHaveEanId<int>, IHaveName
    {
        public int EanId { get; set; } = int.MinValue;

        public string Name { get; set; }

        public virtual ICollection<Accommodation> Accommodations { get; set; }
    }
}