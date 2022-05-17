using Autofac;
using ViewModels;
using ModuleBLL;

namespace ModulesAPI
{
    public class ControllersModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // level below registration
            builder.RegisterModule<MappersModule>();
            builder.RegisterModule<ServicesModule>();
        }
    }
}
