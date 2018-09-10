using System;
using System.Linq.Expressions;

namespace Olbrasoft.Data
{
    public interface IQueryBuilder
    {
        T Build<T>() where T : IQuery;

        T Build<T>(Expression<Func<T,object>> memberSelector, object value) where T : IQuery;
    }
}