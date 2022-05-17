namespace Services.Abstract
{
    public interface IService<TDomain> where TDomain : class
    {
        void Add(TDomain domain);
        void Update(TDomain domain);
        void Remove(int id);
        TDomain Get(int id);
        List<TDomain> GetAll();
        void Save();
    }
}
