using Castle.Facilities.TypedFactory;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Olbrasoft.Castle.Facilities.TypedFactory;
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
            container.AddFacility<TypedFactoryFacility>();

            container.Register(
                Component.For(typeof(IQueryProcessor))
                    .AsFactory(c => c.SelectedWith(new QueryProcessorFactorySelector()))
                    .LifestyleTransient());
        }
    }
}