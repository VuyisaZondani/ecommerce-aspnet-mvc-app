using eTickets.Models;

namespace eTickets.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        //Returns single actor
        Task<T> GetByIdAsync(int id);
        //Adds data to database
        Task AddAsync(T entity);
        //func to update data
        Task UpdateAsync(int id, T entity);

        Task DeleteAsync(int id);
    }
}
