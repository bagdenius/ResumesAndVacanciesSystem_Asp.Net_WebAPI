using Autofac;
using Domain;
using Services;
using Services.Abstract;

namespace ModulesBLL
{
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ResumeService>().As<IService<Resume>>()/*.SingleInstance()*/;
            builder.RegisterType<VacancyService>().As<IService<Vacancy>>()/*.SingleInstance()*/;
            builder.RegisterType<UserService>().As<IService<User>>()/*.SingleInstance()*/;
        }
    }
}
