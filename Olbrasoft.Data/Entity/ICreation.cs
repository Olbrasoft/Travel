using System;

namespace Olbrasoft.Data.Entity
{
    public interface ICreation<TKey> : IHaveKeyId<TKey>
    {
        DateTime DateAndTimeOfCreation { get; set; }
    }
}