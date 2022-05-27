using CommandsAndQueries.UserCommands.AddUser;
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
            //services.AddTransient<IService<AddResumeModel, UpdateResumeModel, ResumeVM>, ResumeService>()
            //    .AddTransient<IService<AddUserModel, UpdateUserModel, UserVM>, UserService>()
            //    .AddTransient<IService<AddVacancyModel, UpdateVacancyModel, VacancyVM>, VacancyService>();

            services.AddAutoMapper(typeof(UserMapper).GetTypeInfo().Assembly);

            services.AddMediatR(typeof(AddUserCommandHandler).GetTypeInfo().Assembly);

            return services;
        }
    }
}
