using Microsoft.AspNetCore.Mvc;
using SupportTickets.Api.Models;

[ApiController]
[Route("api/[controller]")]

public class TicketsController : ControllerBase
{
    public static readonly List<Ticket> Tickets = new();

    [HttpGet]
    public ActionResult<List<Ticket>> GetAllTickets()
    {
        return Ok(Tickets);
    }

    [HttpGet("{id}")]
    public ActionResult<Ticket> GetTicketById(int id)
    {
        Ticket? ticket = Tickets.FirstOrDefault(t => t.Id == id);
        if (ticket == null)
            return NotFound();
        return Ok(ticket);
    }

    [HttpPost]
    public ActionResult<Ticket> CreateTicket(Ticket ticket)
    {
        ticket.Id = Tickets.Count + 1;
        ticket.CreatedAt = DateTime.UtcNow;

        Tickets.Add(ticket);
        return CreatedAtAction(nameof(GetTicketById), new {id = ticket.Id}, ticket);
    }


    [HttpPut("{id}")]
    public ActionResult UpdateTicket(int id, Ticket updatedTicket)
    {
        var ticket = Tickets.FirstOrDefault(t => t.Id == id);

        if(ticket == null)
            return NotFound();
        ticket.Title = updatedTicket.Title;
        ticket.Description = updatedTicket.Description;
        ticket.Status = updatedTicket.Status;
        ticket.Priority = updatedTicket.Priority;
        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteTicket(int id)
    {
        var ticket = Tickets.FirstOrDefault(t => t.Id == id);

        if(ticket == null)
            return NotFound();

        Tickets.Remove(ticket);

        return NoContent();
    }
}