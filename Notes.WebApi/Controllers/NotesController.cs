using Microsoft.AspNetCore.Mvc;
using Notes.Application.Notes.Commands.Create;
using Notes.Application.Notes.Queries.Get;
using Notes.Application.Notes.Queries.GetList;
using Notes.Domain;

namespace Notes.WebApi.Controllers;

[Route("api/[controller]")]
public class NoteController : Controller
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Note>>> Get()
    {
        var query = new GetNoteListQuery();
        var note = await Mediator.Send(query);
        return Ok(note);
    }
    
    [HttpGet("{id:guid}")]
    public async Task<ActionResult<Note>> Get(Guid id)
    {
        var query = new GetNoteQuery(id);
        var note = await Mediator.Send(query);
        return Ok(note);
    }

    [HttpPost]
    public async Task<ActionResult<Note>> Create([]string title, string text)
    {
        var command = new CreateNoteCommand(title, text);
        var note = await Mediator.Send(command);
        return Ok(note);
    }
}