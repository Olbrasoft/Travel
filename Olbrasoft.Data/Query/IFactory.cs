namespace Olbrasoft.Data.Query
{
    public interface IFactory
    {
        T Create<T>() where T : IQuery;
    }
}