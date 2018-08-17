namespace Olbrasoft.Shared.Pagination
{
    public interface IPageResult<out T> : IResult<T>
    {
        IPaging Paging { get; }

    }
}
