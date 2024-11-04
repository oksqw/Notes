using MediatR;
using Notes.Domain;

namespace Notes.Application.Notes.Queries;

public class GetNoteQuery : IRequest<Note>
{
    public Guid Id { get; set; }
}