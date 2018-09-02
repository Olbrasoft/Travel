using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Olbrasoft.Travel.Business.Facades;
using Olbrasoft.Shared;
using Olbrasoft.Shared.UnitTest;

namespace Olbrasoft.Travel.Web.Mvc.Installers
{
   public partial class ControllersInstaller
    {
        public class BusinessLogicLayerInstaller : IWindsorInstaller
        {
            public void Install(IWindsorContainer container, IConfigurationStore store)
            {
                container.Register(Component.For<IAccommodationsFacade>().ImplementedBy<AccommodationsFacade>().LifestylePerWebRequest());
                container.Register(Component.For<ILanguageService>().ImplementedBy<ThreadCultureLanguageService>().LifestylePerWebRequest());

            }
        }
    }
}