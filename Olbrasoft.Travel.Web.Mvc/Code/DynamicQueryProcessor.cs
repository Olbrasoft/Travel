using System.Linq;
using Olbrasoft.Data;
using Olbrasoft.Travel.Business;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Web.Mvc.Code
{
    using Castle.Windsor;
    using System.Diagnostics;

    public sealed class DynamicQueryProcessor : IQueryProcessor
    {
        private readonly IWindsorContainer _container;

        public DynamicQueryProcessor(IWindsorContainer container)
        {
            _container = container;
        }

       
        public TResult Execute<TResult>(IQuery<TResult> query)
        {
            var handlerType = typeof(IQueryHandler<,>).MakeGenericType(query.GetType(), typeof(TResult));


            dynamic handler = _container.Resolve(handlerType);
                //new LocalizedAccommodationsQueryHandler(_container.Resolve<IQueryable<LocalizedAccommodation>>());
            return handler.Handle((dynamic)query);
        }
    }
}