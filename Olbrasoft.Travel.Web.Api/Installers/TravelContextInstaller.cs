using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

using Olbrasoft.Travel.Data.Entity;
using Olbrasoft.Travel.Data.Entity.Model;

namespace Olbrasoft.Travel.Web.Api.Installers
{
    public class TravelContextInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            //container.Register(Component.For<ITravelContext>().ImplementedBy<TravelDatabaseContext>().LifestylePerWebRequest());
        }
    }
}