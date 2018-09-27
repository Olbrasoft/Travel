using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Olbrasoft.Data.Query;

namespace Olbrasoft.Travel.Web.Mvc.Installers.Query
{
    public class Provider : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IProvider>().ImplementedBy<ProviderWithWrapperAndDependentResolver>().LifestyleSingleton());

            container.Register(Component
                .For(typeof(ProviderWithWrapperAndDependentResolver.WrapperWithDependentHandler<,>))
                .ImplementedBy(typeof(ProviderWithWrapperAndDependentResolver.WrapperWithDependentHandler<,>))
                .LifestylePerWebRequest());
        }
    }
}