using System.Collections.Generic;

namespace Olbrasoft.Travel.BusinessLogicLayer
{
    public interface ITravelFacade<in T>where T:class
    {
        void Add(T item);
        void Add(IEnumerable<T> items);
        void Update(T item);

    }
}
