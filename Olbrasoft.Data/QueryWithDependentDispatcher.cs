using System.Threading;
using System.Threading.Tasks;
using Olbrasoft.Data.Query;

namespace Olbrasoft.Data
{
    public abstract class QueryWithDependentDispatcher<TResult> : IQuery<TResult>
    {
        protected IDispatcher QueryDispatcher { get; }

        protected QueryWithDependentDispatcher(IDispatcher queryDispatcher)
        {
            QueryDispatcher = queryDispatcher;
        }

        public TResult Execute()
        {
            return QueryDispatcher.Dispatch(this);
        }

        public Task<TResult> ExecuteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return QueryDispatcher.DispatchAsync(this, cancellationToken);
        }
    }
}