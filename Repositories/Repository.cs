using Database;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DatabaseContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(DatabaseContext context) =>
            (_context, _dbSet) = (context, context.Set<TEntity>());

        public void Add(TEntity entity) =>
            _dbSet.Add(entity);

        //public async void AddAsync(TEntity entity, CancellationToken cancellationToken) =>
        //    await _dbSet.AddAsync(entity, cancellationToken);

        public void Update(TEntity entity) =>
            _context.Entry(entity).State = EntityState.Modified;

        public void Remove(int id) =>
            _dbSet.Remove(_dbSet.Find(id));

        public TEntity Get(int id) => 
            _dbSet.Find(id);

        public List<TEntity> GetAll() => 
            _dbSet.ToList();
    }
}
