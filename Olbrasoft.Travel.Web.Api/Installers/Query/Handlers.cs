using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Olbrasoft.Travel.Web.Api.Installers.Query
{
    public class Handlers : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var classes = Classes.FromAssemblyNamed("Olbrasoft.Travel.Data.Entity");
            
            container.Register(classes
            .Where(ns=>ns.Namespace != null && ns.Namespace.EndsWith("Query.Handler"))
                .WithServiceFirstInterface()
            .LifestylePerWebRequest());


        }
    }
}