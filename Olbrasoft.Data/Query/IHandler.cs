using System.Threading;
using System.Threading.Tasks;

namespace Olbrasoft.Data.Query
{
    public interface IHandler<in TQuery, TResult> where TQuery : IQuery<TResult>
    {
        TResult Handle(TQuery query);

        Task<TResult> HandleAsync(TQuery query);

        Task<TResult> HandleAsync(TQuery query, CancellationToken cancellationToken);
    }
}