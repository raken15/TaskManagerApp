namespace TaskManager.UI.Repository
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Delete(T entity);
        T FindById(int id);
        IEnumerable<T> GetAll();
        void Update(T entity);
    }
}