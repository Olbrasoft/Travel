using AutoMapper;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Olbrasoft.Shared;
using Olbrasoft.Shared.UnitTest;
using Olbrasoft.Travel.Business.Facades;
using Olbrasoft.Travel.Business.Mapping;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Transfer.Objects;

namespace Olbrasoft.Travel.Web.Mvc.Installers
{
    public partial class ControllersInstaller
    {
        public class BusinessLogicLayerInstaller : IWindsorInstaller
        {
            public void Install(IWindsorContainer container, IConfigurationStore store)
            {
                var config = new MapperConfiguration(cfg => cfg.AddProfile<AccommodationProfile>());
                var mapper = config.CreateMapper();

                container.Register(Component.For<IPagedListMapper<Accommodation, AccommodationDto>>()
                    .ImplementedBy<PagedListAutoMapper<Accommodation, AccommodationDto>>()
                    .DependsOn(Dependency.OnValue(typeof(IMapper), mapper)).LifestylePerWebRequest());

                container.Register(Component.For<IAccommodationsFacade>().ImplementedBy<AccommodationsFacade>().LifestylePerWebRequest());
                container.Register(Component.For<ILanguageService>().ImplementedBy<ThreadCultureLanguageService>().LifestylePerWebRequest());
            }
        }
    }
}