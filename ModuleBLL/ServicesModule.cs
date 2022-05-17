using Autofac;
using Domain;
using ModulesDAL;
using Services;
using Services.Abstract;

namespace ModuleBLL
{
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ResumeService>().As<IService<Resume>>().SingleInstance();
            builder.RegisterType<VacancyService>().As<IService<Vacancy>>().SingleInstance();
            builder.RegisterType<UserService>().As<IService<User>>().SingleInstance();
            // level below registration
            builder.RegisterModule<DatabaseModule>();
            builder.RegisterModule<RepositoriesModule>();
            builder.RegisterModule<UnitOfWorkModule>();
        }
    }
}
