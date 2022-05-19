using Database.Abstract;
using Database.EntityTypeConfigurations;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        public DatabaseContext()
        { 
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<ResumeEntity> Resumes { get; set; }
        public DbSet<VacancyEntity> Vacancies { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new ResumeConfiguration());
            builder.ApplyConfiguration(new VacancyConfiguration());
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => 
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ResumesAndVacancies");
    }
}
