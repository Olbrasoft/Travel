using System;
using System.Diagnostics;
using AutoMapper;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Olbrasoft.Data;
using Olbrasoft.Pagination.Collections.Generic;
using Olbrasoft.Shared;
using Olbrasoft.Shared.UnitTest;
using Olbrasoft.Travel.Business;
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

                //container.Register(Component.For<IQueryProcessor>().ImplementedBy<DynamicQueryProcessor>()
                  //  .DependsOn(Dependency.OnValue(typeof(IWindsorContainer), container)).LifestylePerWebRequest());
                

                var config = new MapperConfiguration(cfg => cfg.AddProfile<LocalizedAccommodationProfile>());
                var mapper = config.CreateMapper();

                container.Register(Component.For<IPagedListMapper<LocalizedAccommodation, AccommodationDto>>()
                    .ImplementedBy<PagedListAutoMapper<LocalizedAccommodation, AccommodationDto>>()
                    .DependsOn(Dependency.OnValue(typeof(IMapper), mapper)).LifestylePerWebRequest());
                
                container.Register(Component.For<ILocalizedAccommodationsFacade>().ImplementedBy<LocalizedAccommodationsFacade>().LifestylePerWebRequest());
                container.Register(Component.For<ILanguageService>().ImplementedBy<ThreadCultureLanguageService>().LifestylePerWebRequest());
            }
        }




    }


   
}