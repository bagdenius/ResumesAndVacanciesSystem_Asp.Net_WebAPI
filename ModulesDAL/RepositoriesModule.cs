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
            builder.RegisterType<Repository<User>>().As<IRepository<User>>()/*.SingleInstance()*/;
            builder.RegisterType<Repository<Resume>>().As<IRepository<Resume>>()/*.SingleInstance()*/;
            builder.RegisterType<Repository<Vacancy>>().As<IRepository<Vacancy>>()/*.SingleInstance()*/;
        }
    }
}
