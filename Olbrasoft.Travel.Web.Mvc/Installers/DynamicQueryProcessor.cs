using Castle.Windsor;
using Olbrasoft.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Olbrasoft.Travel.Web.Mvc.Installers
{
    public class DynamicQueryProcessor : IQueryProcessor
    {
        private readonly IWindsorContainer _container;

        public DynamicQueryProcessor(IWindsorContainer container)
        {
            _container = container;
        }

        public TResult Process<TResult>(IQuery<TResult> query)
        {
            var handler = GetHandler(query);

            return handler.Handle((dynamic)query);
        }

        public Task<TResult> ProcessAsync<TResult>(IQuery<TResult> query)
        {
            return GetHandler(query).HandleAsync((dynamic)query);
        }

        public Task<TResult> ProcessAsync<TResult>(IQuery<TResult> query, CancellationToken cancellationToken)
        {
            return GetHandler(query).HandleAsync((dynamic)query, cancellationToken);
        }

        private dynamic GetHandler<TResult>(IQuery<TResult> query)
        {
            var queryType = query.GetType();

            var allInterfaces = queryType.GetInterfaces();
            var minimalInterfaces = from iType in allInterfaces
                                    where !allInterfaces.Any(t => t.GetInterfaces()
                                        .Contains(iType))
                                    select iType;

            var queryInterfaceType = minimalInterfaces.FirstOrDefault();

            var handlerType = typeof(IQueryHandler<,>).MakeGenericType(query.GetType(), typeof(TResult));

            // var handlerType = typeof(IQueryHandler<,>).MakeGenericType(queryInterfaceType, typeof(TResult));



            return _container.Resolve(handlerType);
        }
    }
}