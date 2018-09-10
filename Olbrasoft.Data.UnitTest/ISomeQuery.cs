namespace Olbrasoft.Data.UnitTest
{
    public interface ISomeQuery : IQuery<object, object>
    {
        int Id { get; set; }
    }
}