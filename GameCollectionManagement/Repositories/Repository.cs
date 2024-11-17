namespace GameCollectionManagement.Repositories
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(int Id);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int Id);

    }
}
