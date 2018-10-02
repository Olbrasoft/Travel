using System;

namespace Olbrasoft.Data.Entity
{
    public interface ICreation<TKey> : IHaveId<TKey>
    {
        DateTime DateAndTimeOfCreation { get; set; }
    }
}