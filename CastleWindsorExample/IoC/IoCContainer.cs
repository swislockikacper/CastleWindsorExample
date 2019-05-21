using Castle.Windsor;
using Castle.Windsor.Installer;
using System.Web.Mvc;

namespace CastleWindsorExample.IoC
{
    public static class IoCContainer
    {
        private static IWindsorContainer container;

        public static void Setup()
        {
            container = new WindsorContainer().Install(FromAssembly.This());

            WindsorControllerFactory controllerFactory = new WindsorControllerFactory(container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }
    }
}