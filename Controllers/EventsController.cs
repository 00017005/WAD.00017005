using Microsoft.AspNetCore.Mvc;
using WAD._00017005.Models;
using WAD._00017005.Repositories;
using WAD._00017005.Data;

namespace WAD._00017005.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventRepository _eventRepository;

        public EventsController(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        // GET: api/events
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Event>>> GetEvents()
        {
            var events = await _eventRepository.GetAllEventsAsync();
            return Ok(events);
        }

        // GET
        [HttpGet("{id}")]
        public async Task<ActionResult<Event>> GetEvent(int id)
        {
            var eventEntity = await _eventRepository.GetEventByIdAsync(id);

            if (eventEntity == null)
            {
                return NotFound();
            }

            return Ok(eventEntity);
        }

        // POST
        [HttpPost]
        public async Task<ActionResult<Event>> PostEvent(Event eventEntity)
        {
            await _eventRepository.AddEventAsync(eventEntity);
            return CreatedAtAction(nameof(GetEvent), new { id = eventEntity.Id }, eventEntity);
        }

        // PUT
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEvent(int id, Event eventEntity)
        {
            if (id != eventEntity.Id)
            {
                return BadRequest();
            }

            await _eventRepository.UpdateEventAsync(eventEntity);

            return NoContent();
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            await _eventRepository.DeleteEventAsync(id);
            return NoContent();
        }
    }
}
