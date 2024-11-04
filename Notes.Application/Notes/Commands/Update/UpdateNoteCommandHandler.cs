using MediatR;
using Microsoft.EntityFrameworkCore;
using Notes.Application.Exceptions;
using Notes.Application.Interfaces;
using Notes.Domain;

namespace Notes.Application.Notes.Commands.Update;

public class UpdateNoteCommandHandler : NoteCommandHandler, IRequestHandler<UpdateNoteCommand, Note>
{
    public UpdateNoteCommandHandler(INotesDbContext dbContext) : base(dbContext) { }
    
    public async Task<Note> Handle(UpdateNoteCommand request, CancellationToken token)
    {
        var note = await _dbContext.Notes.FirstOrDefaultAsync(x => x.Id == request.Id, token);
        if (note is null) throw new NoteNotFoundException(request.Id);

        note.Title = request.Title;
        note.Text = request.Text;
        note.UpdatedAt = DateTime.Now;
        await _dbContext.SaveChangesAsync(token);
        
        return note;
    }
}