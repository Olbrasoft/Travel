using System.Threading;
using System.Threading.Tasks;

namespace Olbrasoft.Data
{
    public abstract class QueryHandler<TQuery, TResult> : IQueryHandler<TQuery, TResult> where TQuery : IQuery<TResult>
    {
        public abstract TResult Handle(TQuery query);

        public async Task<TResult> HandleAsync(TQuery query)
        {
            return await HandleAsync(query, default(CancellationToken));
        }

        public abstract Task<TResult> HandleAsync(TQuery query, CancellationToken cancellationToken);
    }
}