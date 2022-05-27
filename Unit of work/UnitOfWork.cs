using Database;
using Entities;
using Repositories.Abstract;
using System;
using System.Threading;
using System.Threading.Tasks;
using UnitOfWork.Abstract;

namespace UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        public IRepository<User> Users { get; }
        public IRepository<Resume> Resumes { get; }
        public IRepository<Vacancy> Vacancies { get; }

        public UnitOfWork(DatabaseContext context, IRepository<User> users,
            IRepository<Resume> resumes, IRepository<Vacancy> vacancies) =>
            (_context, Users, Resumes, Vacancies) = (context, users, resumes, vacancies);
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
