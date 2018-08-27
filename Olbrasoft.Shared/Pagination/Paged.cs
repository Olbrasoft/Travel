namespace Olbrasoft.Shared.Pagination
{
    public class Paged<T>
    {
        /// <summary>Information about the requested page.</summary>
        public PageInfo Paging { get; set; }

        /// <summary>The list of items for the given page.</summary>
        public IEnumerableItems<T> Items { get; set; }
    }
}