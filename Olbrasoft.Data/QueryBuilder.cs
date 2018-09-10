using System;
using System.Linq.Expressions;

namespace Olbrasoft.Data
{
    public class QueryBuilder : IQueryBuilder
    {
        private readonly IQueryFactory _queryFactory;

        public QueryBuilder(IQueryFactory queryFactory)
        {
            _queryFactory = queryFactory;
        }

        public T Build<T>() where T : IQuery
        {
            return _queryFactory.Create<T>();
        }

        public T Build<T>(Expression<Func<T, object>> memberSelector, object value) where T : IQuery
        {
            var query = Build<T>();
            return query.SetAndReturn(memberSelector, value);
        }
    }
}