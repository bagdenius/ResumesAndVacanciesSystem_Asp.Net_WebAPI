using Database;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace BLL.Tests.Common
{
    public static class ContextFactory
    {
        public static Guid UserIdForUpdate = Guid.NewGuid();
        public static Guid UserIdForDelete = Guid.NewGuid();

        public static Guid ResumeIdForUpdate = Guid.NewGuid();
        public static Guid ResumeIdForDelete = Guid.NewGuid();

        public static Guid VacancyIdForUpdate = Guid.NewGuid();
        public static Guid VacancyIdForDelete = Guid.NewGuid();

        public static DatabaseContext Create()
        {
            var options = new DbContextOptionsBuilder<DatabaseContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            var context = new DatabaseContext(options);
            context.Database.EnsureCreated();
            context.Users.AddRange(
                new User
                {

                });
            context.SaveChanges();
            return context;
        }

        public static void Destroy(DatabaseContext context)
        {
            context.Database.EnsureDeleted();
            context.Dispose();
        }
    }
}
