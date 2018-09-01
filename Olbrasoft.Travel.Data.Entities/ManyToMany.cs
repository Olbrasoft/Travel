using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Olbrasoft.Travel.Data.Entities
{
    public class ManyToMany : CreatorInfo
    {
        [Key]
        [Column(Order = 2)]
        public int ToId { get; set; }
    }
}