using MediatR;
using Notes.Domain;

namespace Notes.Application.Notes.Commands;

public abstract class NoteCommand : IRequest<Note>
{
    protected NoteCommand(string title, string text) => (Title, Text) = (title, text);
    public string Title { get; set; }
    public string Text { get; set; }
}