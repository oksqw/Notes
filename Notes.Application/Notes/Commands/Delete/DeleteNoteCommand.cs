using MediatR;
using Notes.Domain;

namespace Notes.Application.Notes.Commands.Delete;

public class DeleteNoteCommand : IRequest<Note>
{
    public DeleteNoteCommand(Guid id) => Id = id;
    public Guid Id { get; set; }
}