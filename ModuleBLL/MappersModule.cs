using Autofac;
using AutoMapper;
using Mappers;

namespace ModuleBLL
{
    public class MappersModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(context => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<UserMapper>();
                cfg.AddProfile<ResumeMapper>();
                cfg.AddProfile<VacancyMapper>();
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
