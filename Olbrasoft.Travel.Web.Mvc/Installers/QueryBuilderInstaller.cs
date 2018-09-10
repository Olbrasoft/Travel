using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Olbrasoft.Data;
using Olbrasoft.Shared;
using Olbrasoft.Shared.UnitTest;

namespace Olbrasoft.Travel.Web.Mvc.Installers
{
    public class QueryBuilderInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IQueryBuilder>().ImplementedBy<QueryBuilder>().LifestylePerWebRequest());
        }
    }
}