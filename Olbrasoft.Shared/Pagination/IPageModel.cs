namespace Olbrasoft.Shared.Pagination
{
    public interface IEnumerableItemsAndPaging<out T> : IEnumerableItems<T>
    {
        IPaging Paging { get; }
    }


}
