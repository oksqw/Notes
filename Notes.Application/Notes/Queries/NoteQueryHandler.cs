using Notes.Application.Interfaces;

namespace Notes.Application.Notes.Queries;

public class QueryHandler
{
    protected QueryHandler(INotesDbContext dbContext) => _dbContext = dbContext;
    
    protected readonly INotesDbContext _dbContext;
}