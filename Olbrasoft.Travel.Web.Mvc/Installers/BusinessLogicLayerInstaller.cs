using AutoMapper;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Olbrasoft.Shared;
using Olbrasoft.Shared.UnitTest;
using Olbrasoft.Travel.Business.Facades;
using Olbrasoft.Travel.Business.Mapping;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Web.Mvc.Installers
{
    public class BusinessLogicLayerInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            //container.Register(Component.For<IQueryProcessor>().ImplementedBy<DynamicQueryProcessor>()
            //  .DependsOn(Dependency.OnValue(typeof(IWindsorContainer), container)).LifestylePerWebRequest());

            var config = new MapperConfiguration(cfg => cfg.AddProfile<LocalizedAccommodationProfile>());
            var mapper = config.CreateMapper();

            container.Register(Component.For<IMapper<LocalizedAccommodation>>()
                .ImplementedBy<AutoMapper<LocalizedAccommodation>>()
                .DependsOn(Dependency.OnValue(typeof(IMapper), mapper)).LifestylePerWebRequest());

            container.Register(Component.For<ILocalizedAccommodationsFacade>().ImplementedBy<LocalizedAccommodationsFacade>().LifestylePerWebRequest());
            container.Register(Component.For<ILanguageService>().ImplementedBy<ThreadCultureLanguageService>().LifestylePerWebRequest());
        }
    }
}