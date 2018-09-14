using Castle.Facilities.TypedFactory;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Olbrasoft.Data;

namespace Olbrasoft.Travel.Web.Mvc.Installers
{
    public class QueryFactoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container.AddFacility<TypedFactoryFacility>();
            container.Register(Component.For<IQueryFactory>()
                .AsFactory());



        }
    }
    
    
}