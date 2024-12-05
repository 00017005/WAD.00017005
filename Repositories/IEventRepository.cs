using WAD._00017005.Models;

namespace WAD._00017005.Repositories
{
    public interface IEventRepository
    {
        Task<IEnumerable<Event>> GetAllEventsAsync();
        Task<Event> GetEventByIdAsync(int id);
        Task AddEventAsync(Event eventEntity);
        Task UpdateEventAsync(Event eventEntity);
        Task DeleteEventAsync(int id);
    }
}
