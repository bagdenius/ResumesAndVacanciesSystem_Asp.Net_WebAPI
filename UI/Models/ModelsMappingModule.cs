using Autofac;
using AutoMapper;
using CommandsAndQueries.EntityViewModelMappers;
using UI.ModelCommandMappers;

namespace UI
{
    public class ModelMappingModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(context => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ResumeVmMapper>();
                cfg.AddProfile<UserVmMapper>();
                cfg.AddProfile<VacancyVmMapper>();
                cfg.AddProfile<ResumeModelMapper>();
                cfg.AddProfile<UserModelMapper>();
                cfg.AddProfile<VacancyModelMapper>();
            }
            )).AsSelf().SingleInstance();

            builder.Register(c =>
            {
                var context = c.Resolve<IComponentContext>();
                var config = context.Resolve<MapperConfiguration>();
                return config.CreateMapper(context.Resolve);
            })
            .As<IMapper>()
            .InstancePerLifetimeScope();
        }
    }
}
