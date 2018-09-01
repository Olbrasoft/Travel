using System.ComponentModel.DataAnnotations;

namespace Olbrasoft.Travel.Data.Entities
{
    public interface IKeyId
    {
         [Key]
         int Id { get; set; }
    }

}
