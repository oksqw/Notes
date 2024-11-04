using MediatR;
using Microsoft.EntityFrameworkCore;
using Notes.Application.Interfaces;
using Notes.Domain;

namespace Notes.Application.Notes.Queries.GetList;

public class GetNoteListQueryHandler : NoteQueryHandler, IRequestHandler<GetNoteListQuery, IEnumerable<Note>>
{
    public GetNoteListQueryHandler(INotesDbContext dbContext) : base(dbContext) { }

    public async Task<IEnumerable<Note>> Handle(GetNoteListQuery request, CancellationToken token) => 
        await _dbContext.Notes.ToListAsync(token);
}