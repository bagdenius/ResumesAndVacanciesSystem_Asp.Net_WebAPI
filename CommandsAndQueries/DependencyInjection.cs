using CommandsAndQueries.ResumeCommands.AddResume;
using Mappers;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ResumeMapper).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(AddResumeCommandHandler).GetTypeInfo().Assembly);
            return services;
        }
    }
}
