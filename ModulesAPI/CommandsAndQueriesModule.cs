using Autofac;
using MediatR.Extensions.Autofac.DependencyInjection;
using Queries.UserCommands.CreateUser;
using Queries.UserQueries.GetUser;
using System.Reflection;

namespace ModulesBLL
{
    public class CommandsAndQueriesModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterMediatR(typeof(AddUserCommandHandler).GetTypeInfo().Assembly);
            builder.RegisterMediatR(typeof(GetUserQueryHandler).GetTypeInfo().Assembly);
        }
    }
}
