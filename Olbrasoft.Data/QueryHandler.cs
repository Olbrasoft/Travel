using System.Threading;
using System.Threading.Tasks;

namespace Olbrasoft.Data
{
    public abstract class QueryHandler<TQuery, TSource, TResult> : IQueryHandler<TQuery, TResult> where TQuery : IQuery<TResult>
    {
        protected TSource Source { get; }

        protected QueryHandler(TSource source)
        {
            Source = source;
        }

        public abstract TResult Handle(TQuery query);

        public Task<TResult> HandleAsync(TQuery query)
        {
           return HandleAsync(query, default(CancellationToken));
        }

        public abstract Task<TResult> HandleAsync(TQuery query, CancellationToken cancellationToken);
    }
}