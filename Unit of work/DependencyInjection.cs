using Microsoft.Extensions.DependencyInjection;
using Repositories;
using Repositories.Abstract;
using Database;
using Microsoft.EntityFrameworkCore;
using Entities;
using UnitOfWork.Abstract;

namespace UnitOfWork
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
        {
            services.AddTransient<IRepository<Resume>, Repository<Resume>>();
            services.AddTransient<IRepository<User>, Repository<User>>();
            services.AddTransient<IRepository<Vacancy>, Repository<Vacancy>>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Test2"));

            return services;
        }
    }
}
