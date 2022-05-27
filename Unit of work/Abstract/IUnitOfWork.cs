using Entities;
using Repositories.Abstract;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace UnitOfWork.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> Users { get; }
        IRepository<Resume> Resumes { get; }
        IRepository<Vacancy> Vacancies { get; }
        Task SaveAsync(CancellationToken cancellationToken);
    }
}
