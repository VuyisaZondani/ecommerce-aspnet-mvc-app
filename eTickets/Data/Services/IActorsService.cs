using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllAsync ();
        //Returns single actor
        Task<Actor> GetByIdAsync(int id);
        //Adds data to database
        Task AddAsync(Actor actor);
        //func to update data
        Task <Actor> UpdateAsync(int id,  Actor newActor);

        Task DeleteAsync(int id);

    }
}
