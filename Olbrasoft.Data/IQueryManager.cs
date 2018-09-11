namespace Olbrasoft.Data
{
    public interface IQueryManager : IQueryBuilder, IQueryProcessor
    {
        IQueryBuilder QueryBuilder { get; }
        IQueryProcessor QueryProcessor { get; }
    }
}