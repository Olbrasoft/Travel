using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Olbrasoft.Travel.Web.Api.Installers.Query
{
    public class Queries : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var classes = Classes.FromAssemblyNamed("Olbrasoft.TravelDatabaseContext.Data");

            container.Register(classes
                .Where(type => type.Namespace != null && type.Namespace.EndsWith("Query"))
                .WithServiceSelf());

            //container.Register(Component.For<ILocalizedAccommodationByIdQuery>()
            //    .ImplementedBy(typeof(LocalizedAccommodationByIdQuery)));
        }
    }
}