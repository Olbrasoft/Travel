using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Olbrasoft.Data;

namespace Olbrasoft.Travel.Web.Mvc.Installers
{
    public class QueryManagerInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IQueryManager>().ImplementedBy<QueryManager>().LifestylePerWebRequest());
        }
    }
}