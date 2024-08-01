namespace JadoTravel.DataAccess.Abstract
{
    public interface IRepository<T> where T : class
    {
        List<T> GetList();
        T GetById(int id);
        void Delete(int id);
        void Create(T entity);
        void Update(T entity);
    }
}
