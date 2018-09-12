using System;
using System.Linq.Expressions;

namespace Olbrasoft.Data
{
    public interface IQueryBuilder
    {
        TQuery Build<TQuery>() where TQuery : IQuery;

        TQuery Build<TQuery>(Expression<Func<TQuery,object>> memberSelector, object value) where TQuery : IQuery;
    }
}