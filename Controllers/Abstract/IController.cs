namespace Controllers.Abstract
{
    public interface IController<TModel> where TModel : class
    {
        void Add(TModel model);
        void Update(TModel model);
        void Remove(int id);
        TModel Get(int id);
        List<TModel> GetAll();
        void Save();
    }
}
