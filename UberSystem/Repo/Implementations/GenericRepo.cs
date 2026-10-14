using Microsoft.EntityFrameworkCore;
using UberSystem.Data;
using UberSystem.Repo.Interfaces;

namespace UberSystem.Repo.Implementations
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly UberContext _context;

        public GenericRepo(UberContext context)
        {
            _context = context;
        }

        public async Task Add(T item)
        {
             await _context.Set<T>().AddAsync(item);
        }

        public void Delete(T item)
        {
            _context.Set<T>().Remove(item);
        }

        public async Task<T?> FindByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public Task<List<T>> GetAllAsync()
        {
            return _context.Set<T>().ToListAsync();
        }

        public void Update(T item)
        {
            _context.Set<T>().Update(item);
        }
    }
}
