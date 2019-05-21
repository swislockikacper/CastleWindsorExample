using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using CastleWindsorExample.Interfaces;
using CastleWindsorExample.Services;

namespace CastleWindsorExample.IoC
{
    public class BusinessLogicInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IDemoService>().ImplementedBy<DemoService>());
            container.Register(Component.For<IMessageService>().ImplementedBy<MessageService>());
        }
    }
}