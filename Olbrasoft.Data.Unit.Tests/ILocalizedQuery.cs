using Olbrasoft.Data.Query;
using Olbrasoft.Globalization;

namespace Olbrasoft.Data.Unit.Tests
{
    public interface ILocalizedQuery<TResult>:IQuery<TResult>,ILocalized
    {
    }
}