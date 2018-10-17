using System;

namespace Olbrasoft.Data.Entity
{
    public class Factory : IFactory
    {
        public T Create<T>()
        {
            return Activator.CreateInstance<T>();
        }
    }

}