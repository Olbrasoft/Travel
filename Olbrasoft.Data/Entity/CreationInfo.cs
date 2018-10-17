using System;

namespace Olbrasoft.Data.Entity
{
    public abstract class CreationInfo<T> : IHaveId<T>, IHaveDateTimeOfCreation
    {
        public T Id { get; set; }

        public DateTime DateAndTimeOfCreation { get; set; }
    }
}