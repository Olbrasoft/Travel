using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Olbrasoft.Travel.Business;
using Olbrasoft.Travel.Business.Facades;
using Olbrasoft.Travel.Data.Transfer.Object;

namespace Olbrasoft.Travel.Web.Mvc.Installers
{
    public class Business : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IAccommodations>()
                .ImplementedBy<AccommodationsFacade>().LifestylePerWebRequest());

            container.Register(Component.For<IAccommodationItemPhotoMerge>()
                .ImplementedBy<AccommodationItemPhotoMerge>().LifestylePerWebRequest());
        }
    }
}