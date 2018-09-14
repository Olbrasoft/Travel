using System;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Olbrasoft.Data
{
    public class QueryManager : IQueryManager
    {
        protected IQueryBuilder QueryBuilder { get; }
        protected IQueryProcessor QueryProcessor { get; }

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
            return QueryBuilder.Build(memberSelector, value);
        }

        public TResult Process<TResult>(IQuery<TResult> query)
        {
            return QueryProcessor.Process(query);
        }

        public Task<TResult> ProcessAsync<TResult>(IQuery<TResult> query)
        {
            return QueryProcessor.ProcessAsync(query);
        }

        public Task<TResult> ProcessAsync<TResult>(IQuery<TResult> query, CancellationToken cancellationToken)
        {
            return QueryProcessor.ProcessAsync(query, cancellationToken);
        }
    }
}