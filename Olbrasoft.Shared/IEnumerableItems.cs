using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olbrasoft.Shared
{
    public interface IEnumerableItems<out T>
    {
        IEnumerable<T> Items { get; }
    }

}
