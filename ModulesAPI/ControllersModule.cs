using Autofac;
using Controllers;
using Controllers.Abstract;
using Models;
using ModuleBLL;

namespace ModulesAPI
{
    public class ControllersModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserController>().As<IController<UserModel>>().SingleInstance();
            builder.RegisterType<ResumeController>().As<IController<ResumeModel>>().SingleInstance();
            builder.RegisterType<VacancyController>().As<IController<VacancyModel>>().SingleInstance();
            // level below registration
            builder.RegisterModule<MappersModule>();
            builder.RegisterModule<ServicesModule>();
        }
    }
}
