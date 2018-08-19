using System.Collections.Generic;

namespace Olbrasoft.Shared
{
    public abstract class EnumerableItems<T> :IEnumerableItems<T>
    {
        public IEnumerable<T> Items { get; }
    
        protected EnumerableItems(IEnumerable<T> items )
        {
            Items = items;
        }

    }
}