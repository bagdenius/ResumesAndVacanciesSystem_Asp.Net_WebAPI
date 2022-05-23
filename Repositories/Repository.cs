using Database;
using Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DatabaseContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(DatabaseContext context) =>
            (_context, _dbSet) = (context, context.Set<TEntity>());

        public async Task AddAsync(TEntity entity, CancellationToken cancellationToken) =>
            await _dbSet.AddAsync(entity, cancellationToken);

        public void Remove(TEntity entity) =>
            _dbSet.Remove(entity);

        public async Task<TEntity> GetAsync(Guid id, CancellationToken cancellationToken) =>
            await _dbSet.FindAsync(new object[] { id }, cancellationToken);

        //public async Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken) =>
        //    await _dbSet.AsNoTracking().ToListAsync(cancellationToken);

        public async Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken)
        {
            if (typeof(TEntity).Equals(typeof(User)))
                return await _dbSet.Include("Resumes").Include("Vacancies")
                    .AsNoTracking().ToListAsync(cancellationToken);
            if (typeof(TEntity).Equals(typeof(Resume)) || typeof(TEntity).Equals(typeof(Vacancy)))
                return await _dbSet.Include("User").AsNoTracking().ToListAsync(cancellationToken);
            return await _dbSet.AsNoTracking().ToListAsync(cancellationToken);
        }
    }
}
