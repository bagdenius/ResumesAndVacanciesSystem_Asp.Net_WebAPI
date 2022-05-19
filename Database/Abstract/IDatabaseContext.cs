using Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Database.Abstract
{
    public interface IDatabaseContext
    {
        DbSet<UserEntity> Users { get; set; }
        DbSet<ResumeEntity> Resumes { get; set; }
        DbSet<VacancyEntity> Vacancies { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
