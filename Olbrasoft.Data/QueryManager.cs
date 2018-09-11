using System;
using System.Linq.Expressions;

namespace Olbrasoft.Data
{
    public class QueryManager : IQueryManager
    {
        public IQueryBuilder QueryBuilder { get; }
        public IQueryProcessor QueryProcessor { get; }

        public QueryManager(IQueryBuilder queryBuilder, IQueryProcessor queryProcessor)
        {
            QueryBuilder = queryBuilder;
            QueryProcessor = queryProcessor;
        }

        public T Build<T>() where T : IQuery
        {
            return QueryBuilder.Build<T>();
        }

        public T Build<T>(Expression<Func<T, object>> memberSelector, object value) where T : IQuery
        {
            return QueryBuilder.Build<T>(memberSelector, value);
        }

        public TResult Execute<TResult>(IQuery<TResult> query)
        {
            return QueryProcessor.Execute(query);
        }
    }
}