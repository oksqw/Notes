using MediatR;
using Notes.Application.Interfaces;
using Notes.Domain;

namespace Notes.Application.Notes.Commands;

public class CreateNoteCommandHandler : IRequestHandler<CreateNoteCommand, Note>
{
    private readonly INotesDbContext _dbContext;

    public CreateNoteCommandHandler(INotesDbContext dbContext) => _dbContext = dbContext;

    public async Task<Note> Handle(CreateNoteCommand request, CancellationToken token)
    {
        var note = new Note(request.Title, request.Text);
        await _dbContext.Notes.AddAsync(note, token);
        await _dbContext.SaveChangesAsync(token);
        
        return note;
    }
}