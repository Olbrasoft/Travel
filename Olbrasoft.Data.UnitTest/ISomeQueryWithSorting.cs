namespace Olbrasoft.Data.UnitTest
{
    public interface ISomeQueryWithSorting : IQueryWithSorting<object, object>
    {
        int Id { get; set; }
    }
}