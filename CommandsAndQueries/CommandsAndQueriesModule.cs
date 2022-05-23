using Autofac;
using MediatR.Extensions.Autofac.DependencyInjection;
using CommandsAndQueries.UserCommands.AddUser;
using CommandsAndQueries.UserQueries.GetUser;
using System.Reflection;

namespace CommandsAndQueries
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
