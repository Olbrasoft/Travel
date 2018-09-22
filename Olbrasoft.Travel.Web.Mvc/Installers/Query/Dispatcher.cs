using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Olbrasoft.Data.Query;

namespace Olbrasoft.Travel.Web.Mvc.Installers.Query
{
    public class Dispatcher : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IDispatcher>().ImplementedBy<DispatcherWithWrapperAndDependentResolver>().LifestyleSingleton());

            container.Register(Component
                .For(typeof(DispatcherWithWrapperAndDependentResolver.WrapperWithDependentHandler<,>))
                .ImplementedBy(typeof(DispatcherWithWrapperAndDependentResolver.WrapperWithDependentHandler<,>))
                .LifestylePerWebRequest());
        }
    }
}