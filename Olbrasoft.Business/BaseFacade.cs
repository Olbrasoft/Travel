using Olbrasoft.Data;
using System;
using System.Linq.Expressions;

namespace Olbrasoft.Business
{
    public abstract class BaseFacade : IFacade
    {
        protected IQueryManager QueryManager { get; }

        protected BaseFacade(IQueryManager queryManager)
        {
            QueryManager = queryManager;
        }

        protected virtual T Execute<T>(IQuery<T> query)
        {
            return QueryManager.Execute(query);
        }

        protected virtual TQuery Build<TQuery>(Expression<Func<TQuery, object>> memberSelector, object value)
            where TQuery : IQuery
        {
            return QueryManager.Build(memberSelector, value);
        }

        protected virtual TQuery Build<TQuery>() where TQuery : IQuery
        {
            return QueryManager.Build<TQuery>();
        }
    }

    public abstract class BaseFacade<TSource> : BaseFacade, IFacade<TSource>
    {
        protected IMapper<TSource> Mapper { get; }

        protected BaseFacade(IQueryManager queryManager, IMapper<TSource> mapper) : base(queryManager)
        {
            Mapper = mapper;
        }

        protected TResult Map<TResult>(TSource source)
        {
            return Mapper.Map<TResult>(source);
        }
    }
}