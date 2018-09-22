using System.ComponentModel.DataAnnotations;
using Olbrasoft.Data.Entity;


namespace Olbrasoft.Travel.Data.Entities
{
    public class BaseName : CreatorInfo, IHaveName
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}