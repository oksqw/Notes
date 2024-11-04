using Notes.Application.Interfaces;

namespace Notes.Application.Notes.Commands;

public abstract class NoteCommandHandler
{
    protected NoteCommandHandler(INotesDbContext dbContext) => _dbContext = dbContext;
    
    protected readonly INotesDbContext _dbContext;
}