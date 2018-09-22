using System;
using System.Linq.Expressions;
using Olbrasoft.Data.Query;

namespace Olbrasoft.Data.Unit.Tests
{
    public class QueryBuilder : IQueryBuilder
    {
        private readonly IFactory _factory;

        public QueryBuilder(IFactory factory)
        {
            _factory = factory;
        }

        public T Build<T>() where T : IQuery
        {
            return _factory.Create<T>();
        }

        public T Build<T>(Expression<Func<T, object>> memberSelector, object value) where T : IQuery
        {
            var query = Build<T>();
            return query.SetAndReturn(memberSelector, value);
        }
    }
}