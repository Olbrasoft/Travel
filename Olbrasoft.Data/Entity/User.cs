using System.ComponentModel.DataAnnotations;

namespace Olbrasoft.Data.Entity
{
    public class User<TKey> : CreationInfo<TKey>, IHaveUserName
    {
        [Required]
        [StringLength(255)]
        public string UserName { get; set; }
    }
}