using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Olbrasoft.Dependence;
using Olbrasoft.Dependence.Inversion.Of.Control.Containers.Castle;

namespace Olbrasoft.Travel.Web.Api.Installers
{
    public class Resolver : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IResolver>().ImplementedBy<ObjectResolverWithDependentCastle>());
        }
    }
}