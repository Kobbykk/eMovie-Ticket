using eMovie_Ticket.Models;

namespace eMovie_Ticket.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        //Get all actors from the Database
        Task<IEnumerable<T>> GetActorsAsync();

        //Return a single Actor
        Task<T> GetByIdAsync(int id);

        //Add data to the Database
        Task AddAsync(T entity);

        //Update data in the Database
        Task UpdateAsync(int id, T entity);

        //Delete data in the Database
        Task DeleteAsync(int id);
    }
}
