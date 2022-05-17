using System.Collections.Generic;

namespace Repositories.Abstract
{
    public interface IRepository<TEntity> where TEntity : class
    {
        public void Add(TEntity entity);
        public void Update(TEntity entity);
        public void Remove(int id);
        public TEntity Get(int id);
        public List<TEntity> GetAll();
    }
}
