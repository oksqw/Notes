using MediatR;
using Notes.Domain;

namespace Notes.Application.Notes.Queries.GetList;

public class GetNoteListQuery : IRequest<IEnumerable<Note>>;