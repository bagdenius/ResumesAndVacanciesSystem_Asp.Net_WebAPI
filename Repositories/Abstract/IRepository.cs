using System;
using System.Collections.Generic;
using System.Threading;

namespace Repositories.Abstract
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        //void AddAsync(TEntity entity, CancellationToken cancellationToken);
        void Update(TEntity entity);
        void Remove(Guid id);
        TEntity Get(Guid id);
        List<TEntity> GetAll();
    }
}
