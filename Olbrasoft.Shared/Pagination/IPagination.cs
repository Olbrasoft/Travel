namespace Olbrasoft.Shared.Pagination
{
    public interface IPagination
    {
        IPageInfo PageInfo { get; }

        int CountWithOutPaging();
    }
}