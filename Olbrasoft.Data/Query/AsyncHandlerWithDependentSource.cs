using System.Threading;
using System.Threading.Tasks;

namespace Olbrasoft.Data.Query
{
    public abstract class AsyncHandlerWithDependentSource<TQuery, TSource, TResult> : IHandler<TQuery, TResult> where TQuery : IQuery<TResult>
    {
        protected TSource Source { get; }

        protected AsyncHandlerWithDependentSource(TSource source)
        {
            Source = source;
        }

        public TResult Handle(TQuery query)
        {
            return HandleAsync(query).Result;
        }

        public Task<TResult> HandleAsync(TQuery query)
        {
            return HandleAsync(query, default(CancellationToken));
        }

        public abstract Task<TResult> HandleAsync(TQuery query, CancellationToken cancellationToken);
    }
}