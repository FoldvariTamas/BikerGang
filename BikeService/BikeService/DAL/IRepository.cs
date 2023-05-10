namespace BikeService.DAL;

public interface IRepository<T>
{
    HashSet<T> GetAll();
    T GetById(int id);
    void Create(T entity);
    void Update(T entity);
    void Delete(int id);
}