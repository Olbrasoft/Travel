using AutoMapper;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Olbrasoft.Data.Mapping;
using Olbrasoft.Data.Mapping.AutoMapper;
using Olbrasoft.Travel.Data.Mapping;

namespace Olbrasoft.Travel.Web.Mvc.Installers
{
    public class Mapping : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IConfigurationProvider>().ImplementedBy<Configuration>().LifestyleSingleton());
            container.Register(Component.For<IProjection>().ImplementedBy<Projector>().LifestyleSingleton());
        }
    }
}