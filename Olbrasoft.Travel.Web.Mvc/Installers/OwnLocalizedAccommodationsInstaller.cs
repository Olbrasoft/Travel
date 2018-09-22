using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Entity;

namespace Olbrasoft.Travel.Web.Mvc.Installers
{
    public class OwnLocalizedAccommodationsInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IHaveLocalizedAccommodations>().ImplementedBy<OwnLocalizedAccommodations>().LifestylePerWebRequest());
        }
    }
}