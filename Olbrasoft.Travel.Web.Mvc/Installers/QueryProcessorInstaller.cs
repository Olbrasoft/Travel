using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Olbrasoft.Data;

namespace Olbrasoft.Travel.Web.Mvc.Installers
{
    /// <summary>
    /// QueryProcessor without concrete implementation
    /// </summary>
    public class QueryProcessorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            #region Registration QueryProcessorWithOutImplementation

            // container.AddFacility<TypedFactoryFacility>();
            //container.Register(
            //    Component.For(typeof(IQueryProcessor))
            //        .AsFactory(c => c.SelectedWith(new QueryProcessorFactorySelector()))
            //        .LifestyleTransient());

            #endregion


            var processor = new DynamicQueryProcessor(container);
            container.Register(Component.For<IQueryProcessor>().Instance(processor).LifestyleSingleton());

            //container.Register(Component.For(typeof(QueryProcessor.IWrapper<>)).ImplementedBy(QueryProcessor.Wrapper<IQuery<>,>));
            //container.Register(Component.For<IQueryProcessor>().Instance(new QueryProcessor(container)).LifestyleSingleton());
        }


    }



    //sealed class QueryProcessor : IQueryProcessor
    //{
    //    public interface IWrapper<TResult> { TResult Handle(IQuery<TResult> query); }
    //    private readonly IWindsorContainer _container;

       

    //    public QueryProcessor(IWindsorContainer container)
    //    {
    //        this._container = container;
    //    }

    //    public TResult Process<TResult>(IQuery<TResult> query)
    //    {
    //        var wrapperType = typeof(Wrapper<,>).MakeGenericType(query.GetType(), typeof(TResult));
    //        var wrapper = (IWrapper<TResult>)_container.Resolve(wrapperType);
    //        return wrapper.Handle(query);
    //    }

    //    public sealed class Wrapper<TQuery, TResult> : IWrapper<TResult> where TQuery : IQuery<TResult>
    //    {
    //        private readonly IQueryHandler<TQuery, TResult> handler;

    //        public Wrapper(IQueryHandler<TQuery, TResult> handler)
    //        {
    //            this.handler = handler;
    //        }

    //        public TResult Handle(IQuery<TResult> query) => handler.Handle((TQuery)query);
    //    }
    //}
}