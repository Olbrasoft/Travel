using Castle.Windsor;
using Castle.Windsor.Installer;
using Olbrasoft.Travel.Web.Api;
using System.Web.Http;
using WebActivatorEx;

[assembly: System.Web.PreApplicationStartMethod(typeof(WindsorActivator), "PreStart")]
[assembly: ApplicationShutdownMethod(typeof(WindsorActivator), "Shutdown")]

namespace Olbrasoft.Travel.Web.Api
{
    public static class WindsorActivator
    {
        public static WindsorContainer Container = new WindsorContainer();

        public static void PreStart()
        {
            Container.Install(FromAssembly.This());
            GlobalConfiguration.Configuration.DependencyResolver = new DependencyResolver(Container.Kernel);
        }

        public static void Shutdown()
        {
            Container?.Dispose();
        }
    }
}