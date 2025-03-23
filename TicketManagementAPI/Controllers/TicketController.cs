using Microsoft.AspNetCore.Mvc;
using TicketManagementAPI.Models;

namespace TicketManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        // ticket example 
        private static List<Ticket> tickets = new List<Ticket>
        {
            new Ticket { Id = 1, Title = "Ticket 1", Description = "Description for ticket 1", Status = "Open", CreatedAt = DateTime.Now }
        };
        [HttpGet]
        public ActionResult<IEnumerable<Ticket>> GetTickets()
        {
            return Ok(tickets);
        }
        [HttpGet("{id}")]
        public ActionResult<Ticket> GetTicket(int id)
        {
            Ticket ticket = null;
            foreach (var t in tickets)
            {
                if (t.Id == id)
                {
                    ticket = t;
                    break;
                }
            }
            if (ticket == null)
            {
                return NotFound();
            }
            return Ok(ticket);
        }
        [HttpPost]
        public ActionResult<Ticket> CreateTicket(Ticket ticket)
        {
            int MaxId = 0;
            foreach (var t in tickets)
            {
                if (t.Id > MaxId)
                {
                    MaxId = t.Id;
                }
            }
            ticket.Id = MaxId + 1;
            tickets.Add(ticket);
            return CreatedAtAction(nameof(GetTicket), new { id = ticket.Id }, ticket);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateTicket(int id, Ticket updatedTicket)
        {
            Ticket ticket = null;
            foreach (var i in tickets)
            {
                if (i.Id == id)
                {
                    ticket = i;
                    break;
                }
            }
            if (ticket == null)
            {
                return NotFound();
            }
            ticket.Title = updatedTicket.Title;
            ticket.Description = updatedTicket.Description;
            ticket.Status = updatedTicket.Status;
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTicket(int id)
        {
            Ticket ticket = null;
            foreach (var i in tickets)
            {
                if (i.Id == id)
                {
                    ticket = i;
                    break;
                }
            }
            if (ticket == null)
            {
                return NotFound();
            }
            tickets.Remove(ticket);
            return NoContent();
        }
    }
}