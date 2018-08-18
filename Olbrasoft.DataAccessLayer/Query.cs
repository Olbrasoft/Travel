using System;

namespace Olbrasoft.DataAccessLayer
{
    public class Query<T>:IQuery<T>
    {
        
        public IQueryResult<T> Execute()
        {
            throw new NotImplementedException();
        }
    }
}