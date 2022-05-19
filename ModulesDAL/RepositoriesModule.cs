using Autofac;
using Entities;
using Repositories;
using Repositories.Abstract;

namespace ModulesDAL
{
    public class RepositoriesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Repository<UserEntity>>().As<IRepository<UserEntity>>()/*.SingleInstance()*/;
            builder.RegisterType<Repository<ResumeEntity>>().As<IRepository<ResumeEntity>>()/*.SingleInstance()*/;
            builder.RegisterType<Repository<VacancyEntity>>().As<IRepository<VacancyEntity>>()/*.SingleInstance()*/;
        }
    }
}
