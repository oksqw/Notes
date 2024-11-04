using Notes.Application.Interfaces;

namespace Notes.Application.Notes.Queries;

public abstract class NoteQueryHandler
{
    protected NoteQueryHandler(INotesDbContext dbContext) => _dbContext = dbContext;
    
    protected readonly INotesDbContext _dbContext;
}