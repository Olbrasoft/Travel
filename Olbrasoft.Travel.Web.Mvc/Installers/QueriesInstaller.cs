﻿using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Olbrasoft.Travel.Web.Mvc.Installers
{
    public class QueriesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var classes = Classes.FromAssemblyNamed("Olbrasoft.Travel.Data");

            container.Register(classes
                .Where(type => type.Namespace != null && type.Namespace.EndsWith("Queries"))
                .WithServiceSelf());

            //container.Register(Component.For<ILocalizedAccommodationByIdQuery>()
            //    .ImplementedBy(typeof(LocalizedAccommodationByIdQuery)));
        }
    }
}