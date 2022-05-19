using Autofac;
using MediatR.Extensions.Autofac.DependencyInjection;
using Queries.UserQueries.GetUser;
using System.Reflection;

namespace ModulesAPI
{
    public class QueriesModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterMediatR(typeof(GetUserQueryHandler).GetTypeInfo().Assembly);
        }
    }
}
