using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Olbrasoft.Data;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Entity;

namespace Olbrasoft.Travel.Web.Mvc.Installers
{
    public class TravelContextInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<ITravelContext>().ImplementedBy<TravelContext>().LifestylePerWebRequest());
            container.Register(Component.For<IHaveQueryable<LocalizedAccommodation>>().ImplementedBy<QueryableOwner<LocalizedAccommodation>>().LifestylePerWebRequest());
            container.Register(Component.For<IHaveQueryable<PhotoOfAccommodation>>().ImplementedBy<QueryableOwner<PhotoOfAccommodation>>().LifestylePerWebRequest());
            container.Register(Component.For<IHaveQueryable<TypeOfRoom>>().ImplementedBy<QueryableOwner<TypeOfRoom>>().LifestylePerWebRequest());
            container.Register(Component.For<IHaveQueryable<AccommodationToAttribute>>().ImplementedBy<QueryableOwner<AccommodationToAttribute>>().LifestylePerWebRequest());
        }
    }
}