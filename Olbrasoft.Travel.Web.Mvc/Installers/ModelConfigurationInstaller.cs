using Castle.Facilities.TypedFactory;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Olbrasoft.Travel.Data.Entity.ModelConfiguration;

namespace Olbrasoft.Travel.Web.Mvc.Installers
{
    public class ModelConfigurationInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            var classes = Classes.FromAssemblyNamed(typeof(IFactory).Assembly.FullName);

            container.Register(classes
                .Where(type => type.Name.EndsWith(typeof(Configuration).Name))
                .WithServiceSelf());

            container.AddFacility<TypedFactoryFacility>();

            container.Register(
                Component.For<IFactory>().AsFactory());
        }
    }
}