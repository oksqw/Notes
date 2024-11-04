using MediatR;
using Notes.Domain;

namespace Notes.Application.Notes.Queries.Get;

public class GetNoteQuery : IRequest<Note>
{
    public GetNoteQuery(Guid id) => Id = id;
    public Guid Id { get; set; }
}