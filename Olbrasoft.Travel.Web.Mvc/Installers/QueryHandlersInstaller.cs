using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Olbrasoft.Travel.Web.Mvc.Installers
{
    public class QueryHandlersInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            
            var classes = Classes.FromAssemblyNamed("Olbrasoft.Travel.Data.Entity.Query");
            
            container.Register(classes
            .Where(type => type.Name.EndsWith("QueryHandler"))
                .WithServiceFirstInterface()
            .LifestyleTransient());
        }
    }
}