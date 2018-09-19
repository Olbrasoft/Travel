using System.Threading;
using System.Threading.Tasks;

namespace Olbrasoft.Data
{
    public abstract class QueryWithDependentQueryProcessor<TResult> : IQuery<TResult>
    {
        protected IQueryProcessor QueryProcessor { get; }

        protected QueryWithDependentQueryProcessor(IQueryProcessor queryProcessor)
        {
            QueryProcessor = queryProcessor;
        }

        public TResult Execute()
        {
            return QueryProcessor.Process(this);
        }

        public Task<TResult> ExecuteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return QueryProcessor.ProcessAsync(this, cancellationToken);
        }
    }
}