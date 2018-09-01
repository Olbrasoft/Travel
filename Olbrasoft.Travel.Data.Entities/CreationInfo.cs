using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Olbrasoft.Travel.Data.Entities
{
    public class CreationInfo : ICreationInfo
    {
        [Key, Column(Order = 1)]
        public int Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateAndTimeOfCreation { get; set; }
    }
}