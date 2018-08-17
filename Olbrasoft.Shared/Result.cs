using System.Collections.Generic;

namespace Olbrasoft.Shared
{
    public abstract class Result<T> :IResult<T>
    {
        public IEnumerable<T> Items { get; }
    
        protected Result(IEnumerable<T> items )
        {
            Items = items;
        }

    }
}