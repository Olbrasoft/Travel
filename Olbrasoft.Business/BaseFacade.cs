using Olbrasoft.Data;

namespace Olbrasoft.Business
{
    public class BaseFacade : IFacade
    {
        protected IQueryBuilder QueryBuilder { get; }



        protected BaseFacade(IQueryBuilder queryBuilder)
        {
            QueryBuilder = queryBuilder;
        }
    }
}