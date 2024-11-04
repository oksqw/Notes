using MediatR;
using Notes.Application.Interfaces;
using Notes.Domain;

namespace Notes.Application.Notes.Commands.Create;

public class CreateNoteCommandHandler : NoteCommandHandler, IRequestHandler<CreateNoteCommand, Note>
{
    public CreateNoteCommandHandler(INotesDbContext dbContext) : base(dbContext) { }

    public async Task<Note> Handle(CreateNoteCommand request, CancellationToken token)
    {
        var note = new Note(request.Title, request.Text);
        await _dbContext.Notes.AddAsync(note, token);
        await _dbContext.SaveChangesAsync(token);
        
        return note;
    }
}