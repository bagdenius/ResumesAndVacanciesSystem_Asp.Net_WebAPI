using Database;
using Entities;
using Repositories.Abstract;
using System;
using System.Threading;
using System.Threading.Tasks;
using UnitOfWOrk.Abstract;

namespace UnitOfWOrk
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        public IRepository<UserEntity> Users { get; }
        public IRepository<ResumeEntity> Resumes { get; }
        public IRepository<VacancyEntity> Vacancies { get; }

        public UnitOfWork(DatabaseContext context, IRepository<UserEntity> users,
            IRepository<ResumeEntity> resumes, IRepository<VacancyEntity> vacancies) =>
            (_context, Users, Resumes, Vacancies) = (context, users, resumes, vacancies);

        public void Save() => _context.SaveChanges();
        public async Task SaveAsync(CancellationToken cancellationToken) =>
            await _context.SaveChangesAsync(cancellationToken);

        #region Disposing

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                    _context.Dispose();
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
