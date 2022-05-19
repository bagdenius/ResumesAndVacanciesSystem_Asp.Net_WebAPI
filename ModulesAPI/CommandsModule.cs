using Autofac;
using MediatR.Extensions.Autofac.DependencyInjection;
using Queries.UserCommands.CreateUser;
using System.Reflection;

namespace ModulesAPI
{
    public class CommandsModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterMediatR(typeof(CreateUserCommandHandler).GetTypeInfo().Assembly);
        }
    }
}
