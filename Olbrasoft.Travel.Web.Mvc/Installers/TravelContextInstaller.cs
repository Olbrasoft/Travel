using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Entity;

namespace Olbrasoft.Travel.Web.Mvc.Installers
{
    public class TravelContextInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<ITravelContext>().ImplementedBy<TravelContext>().LifestylePerWebRequest());

        }
    }
}