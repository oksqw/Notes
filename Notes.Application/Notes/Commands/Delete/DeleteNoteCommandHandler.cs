using MediatR;
using Microsoft.EntityFrameworkCore;
using Notes.Application.Exceptions;
using Notes.Application.Interfaces;
using Notes.Domain;

namespace Notes.Application.Notes.Commands.Delete;

public class DeleteNoteCommandHandler : NoteCommandHandler, IRequestHandler<DeleteNoteCommand, Note>
{
    public DeleteNoteCommandHandler(INotesDbContext dbContext) : base(dbContext) { }

    public async Task<Note> Handle(DeleteNoteCommand request, CancellationToken token)
    {
        var note = await _dbContext.Notes.FirstOrDefaultAsync(x => x.Id == request.Id, token);
        if (note is null) throw new NoteNotFoundException(request.Id);

        _dbContext.Notes.Remove(note);
        await _dbContext.SaveChangesAsync(token);

        return note;
    }
}