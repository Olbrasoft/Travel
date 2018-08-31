using Olbrasoft.Shared.Pagination;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Olbrasoft.Shared.Collections.Generic
{
    internal class PagedEnumerable<T> : IPagedEnumerable<T>
    {
        protected IEnumerable<T> Items { get; }
        public IPagination Pagination { get; }

        public PagedEnumerable(IEnumerable<T> items, IPagination pagination)
        {
            Items = items;
            Pagination = pagination;
        }
        
        public PagedEnumerable(IEnumerable<T> items)
        {
            var enumerable = items as T[] ?? items.ToArray();
            Items = enumerable;
            Pagination = new Pagination.Pagination(new PageInfo(enumerable.Length), enumerable.Count);
   
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}