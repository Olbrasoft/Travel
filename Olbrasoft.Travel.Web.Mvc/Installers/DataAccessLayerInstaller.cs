using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Olbrasoft.Travel.Web.Mvc.Installers
{
    using Olbrasoft.Data.Entity;
    using Olbrasoft.Travel.Data.Entity;
    using Olbrasoft.Travel.Data.Entity.Query;

    public partial class ControllersInstaller
    {
        public class DataAccessLayerInstaller : IWindsorInstaller
        {
            public void Install(IWindsorContainer container, IConfigurationStore store)
            {

                var queryable = new TravelContext().Accommodations;

                container.Register(Component.For<ILocalizedPagedQuery<Accommodation>>()
                    .ImplementedBy<AccommodationPagedQuery>().DependsOn(Dependency.OnValue("queryable", queryable)).LifestylePerWebRequest());

                //   container.Register(Component.For<DbContext>().ImplementedBy<TravelContext>().LifestylePerWebRequest());
                //  container.Register(Component.For(typeof(IMappedEntitiesRepository<>)).ImplementedBy(typeof(MappedEntitiesRepository<>)).LifestylePerWebRequest());
            }
        }
    }
}