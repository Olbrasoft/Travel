namespace Olbrasoft.Pagination
{
    public interface IPageInfo : INumberSelectedPage
    {
        int PageSize { get; }
    }
}