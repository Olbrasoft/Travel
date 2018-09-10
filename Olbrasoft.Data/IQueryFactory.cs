namespace Olbrasoft.Data
{
    public interface IQueryFactory
    {
        T Create<T>() where T : IQuery;
    }
}