using System.Data.Entity;
using System.Linq;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Olbrasoft.Design.Pattern.Behavior;
using Olbrasoft.Pagination.Collections.Generic;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Entity;
using Olbrasoft.Travel.Data.Entity.Queries;

namespace Olbrasoft.Travel.Web.Mvc.Installers
{
    public partial class ControllersInstaller
    {
        public class DataAccessLayerInstaller : IWindsorInstaller
        {
            public void Install(IWindsorContainer container, IConfigurationStore store)
            {
                var queryable = new TravelContext().LocalizedAccommodations.Include(p=>p.Accommodation);

                container.Register(Component.For<IQueryable<LocalizedAccommodation>>().Instance(queryable));
                
                container.Register(Component
                    .For<IQuery<ILocalizedPagedQueryArgument, IPagedList<LocalizedAccommodation>>>() 
                    .ImplementedBy<LocalizedAccommodationsPagedQuery>());

                
                //container.Register(Component.For<IQuery<ILocalizedPagedQueryArgument, IPagedList<LocalizedAccommodation>>>()
                //    .ImplementedBy<LocalizedAccommodationsPagedQuery>().DependsOn(Dependency.OnValue("queryable", queryable)).LifestylePerWebRequest());

                //container.Register(Component
                //    .For(typeof(IQueryHandler<,>))
                //    .ImplementedBy<LocalizedAccommodationsQueryHandler>().DependsOn(Dependency.OnValue("queryable", queryable))
                //    .LifestylePerWebRequest());

                //container.Register(Component.For<ILocalizedPagedQuery<Accommodation>>()
                //    .ImplementedBy<AccommodationPagedQuery>().DependsOn(Dependency.OnValue("queryable", queryable)).LifestylePerWebRequest());

                //   container.Register(Component.For<DbContext>().ImplementedBy<TravelContext>().LifestylePerWebRequest());
                //  container.Register(Component.For(typeof(IMappedEntitiesRepository<>)).ImplementedBy(typeof(MappedEntitiesRepository<>)).LifestylePerWebRequest());
            }
        }
    }
}