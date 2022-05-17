namespace Services.Abstract
{
    public interface IService<TDomain> where TDomain : class
    {
        void Add(TDomain domain);
        void Update(TDomain domain);
        void Remove(Guid id);
        TDomain Get(Guid id);
        List<TDomain> GetAll();
        void Save();
    }
}
