using System.Threading;
using System.Threading.Tasks;

namespace Olbrasoft.Data
{
    public interface IQueryProcessor
    {
        TResult Process<TResult>(IQuery<TResult> query);

        Task<TResult> ProcessAsync<TResult>(IQuery<TResult> query);

        Task<TResult> ProcessAsync<TResult>(IQuery<TResult> query, CancellationToken cancellationToken);
    }
}