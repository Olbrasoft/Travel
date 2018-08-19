using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Olbrasoft.DataAccessLayer
{
    public interface IQuery<out T>
    {
        IQueryResult<T> Execute();
    }
}
