using Entities;
using Repositories.Abstract;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace UnitOfWOrk.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<UserEntity> Users { get; }
        IRepository<ResumeEntity> Resumes { get; }
        IRepository<VacancyEntity> Vacancies { get; }
        void Save();
        Task SaveAsync(CancellationToken cancellationToken);
    }
}
