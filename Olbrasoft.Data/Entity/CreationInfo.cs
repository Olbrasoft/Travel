using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Olbrasoft.Data.Entity
{
    public abstract class CreationInfo<TKey> : ICreation<TKey>
    {
        [Key, Column(Order = 1)]
        public TKey Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateAndTimeOfCreation { get; set; }
    }
}