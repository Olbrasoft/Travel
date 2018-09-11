namespace Olbrasoft.Data.UnitTest
{
    public class SomQuery : QueryWithSorting<object, object>, ISomeQueryWithSorting
    {
        public int Id { get; set; }
    }
}