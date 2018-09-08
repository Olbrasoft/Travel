using Castle.Windsor;
using Olbrasoft.Data;
using Olbrasoft.Travel.Business;

namespace Olbrasoft.Travel.Web.Mvc.Code
{
    internal sealed class QueryProcessor : IQueryProcessor
    {
        private interface IWrapper<TResult> { TResult Handle(IQuery<TResult> query); }

        private readonly IWindsorContainer _container;

        public QueryProcessor(IWindsorContainer container)
        {
            _container = container;
        }

        public TResult Execute<TResult>(IQuery<TResult> query)
        {
            var wrapperType = typeof(Wrapper<,>).MakeGenericType(query.GetType(), typeof(TResult));
            var wrapper = (IWrapper<TResult>)_container.Resolve(wrapperType);
            return wrapper.Handle(query);
        }

        public sealed class Wrapper<TQuery, TResult> : IWrapper<TResult> where TQuery : IQuery<TResult>
        {
            private readonly IQueryHandler<TQuery, TResult> handler;

            public Wrapper(IQueryHandler<TQuery, TResult> handler)
            {
                this.handler = handler;
            }

            public TResult Handle(IQuery<TResult> query) => handler.Handle((TQuery)query);
        }
    }
}