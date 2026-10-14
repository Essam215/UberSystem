
namespace UberSystem.Repo.Interfaces
{
    public interface IGenericRepo<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T?> FindByIdAsync(int id);
        Task Add(T item);
        void Delete(T item);
        void Update(T item);

    }
}
