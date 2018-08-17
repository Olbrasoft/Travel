namespace Olbrasoft.Shared.Pagination
{
    public interface IPageInfo :INumberSelectedPage
    {
        int PageSize { get; }
    }
}