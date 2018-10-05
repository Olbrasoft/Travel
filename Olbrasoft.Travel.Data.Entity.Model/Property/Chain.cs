using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Olbrasoft.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity.Model.Property
{
    public class Chain : CreatorInfo, IHaveEanId<int>, IHaveName
    {
        public int EanId { get; set; } = int.MinValue;

        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        public virtual ICollection<Accommodation> Accommodations { get; set; }
    }
}