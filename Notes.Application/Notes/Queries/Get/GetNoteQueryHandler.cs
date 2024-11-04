using MediatR;
using Microsoft.EntityFrameworkCore;
using Notes.Application.Exceptions;
using Notes.Application.Interfaces;
using Notes.Domain;

namespace Notes.Application.Notes.Queries.Get;

public class GetNoteQueryHandler : NoteQueryHandler, IRequestHandler<GetNoteQuery, Note>
{
    public GetNoteQueryHandler(INotesDbContext dbContext) : base(dbContext) { }
    
    public async Task<Note> Handle(GetNoteQuery request, CancellationToken token)
    {
        var note = await _dbContext.Notes.FirstOrDefaultAsync(x => x.Id == request.Id, token);
        if (note is null) throw new NoteNotFoundException(request.Id);

        return note;
    }

}
