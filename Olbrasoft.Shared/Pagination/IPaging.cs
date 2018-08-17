namespace Olbrasoft.Shared.Pagination
{
    public interface IPaging : INumberSelectedPage
    {
        int NumberOfPages { get; }
    }
}