using eMovie_Ticket.Models;

namespace eMovie_Ticket.Data.Services
{
    public interface IActorsService
    {
        //Get all actors from the Database
        Task<IEnumerable<Actor>> GetActorsAsync();

        //Return a single Actor
        Task<Actor> GetByIdAsync(int id);

        //Add data to the Database
        Task AddAsync(Actor actor);

        //Update data in the Database
        Task<Actor> UpdateAsync(int id, Actor newActor);

        //Delete data in the Database
        Task DeleteAsync(int id);
    }
}
