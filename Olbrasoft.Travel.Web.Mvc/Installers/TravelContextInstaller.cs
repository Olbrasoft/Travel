using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Olbrasoft.Data;
using Olbrasoft.Travel.Data;
using Olbrasoft.Travel.Data.Entity;
using Olbrasoft.Travel.Data.Entity.Model;
using Olbrasoft.Travel.Data.Entity.Model.Globalization;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Web.Mvc.Installers
{
    public class TravelContextInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            //container.Register(Component.For<ITravelContext>().ImplementedBy<TravelDatabaseContext>().LifestylePerWebRequest());
            //container.Register(Component.For<ITravelContext>().ImplementedBy<TravelDatabaseContext>().DependsOn(Dependency.OnValue(typeof(IFactory), configurationFactory)));

            container.Register(Component.For<IGlobalizationContext>().ImplementedBy<GlobalizationDatabaseContext>().LifestylePerWebRequest());
            container.Register(Component.For<IPropertyContext>().ImplementedBy<PropertyDatabaseContext>().LifestylePerWebRequest());

            
            container.Register(Component.For<IHaveGlobalizationQueryable<LocalizedAccommodation>>().ImplementedBy<GlobalizationQueryableOwner<LocalizedAccommodation>>().LifestylePerWebRequest());
            
            container.Register(Component.For<IHavePropertyQueryable<PhotoOfAccommodation>>().ImplementedBy<PropertyQueryableOwner<PhotoOfAccommodation>>().LifestylePerWebRequest());
            container.Register(Component.For<IHavePropertyQueryable<TypeOfRoom>>().ImplementedBy<PropertyQueryableOwner<TypeOfRoom>>().LifestylePerWebRequest());
            container.Register(Component.For<IHaveGlobalizationQueryable<AccommodationToAttribute>>().ImplementedBy<GlobalizationQueryableOwner<AccommodationToAttribute>>().LifestylePerWebRequest());
        }
    }
}