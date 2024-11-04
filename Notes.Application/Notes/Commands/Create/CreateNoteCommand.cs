using MediatR;
using Notes.Domain;

namespace Notes.Application.Notes.Commands;

public class CreateNoteCommand : IRequest<Note>
{
    public CreateNoteCommand(string title, string text)
    {
        Title = title;
        Text = text;
    }

    public string Title { get; set; }
    public string Text { get; set; }
}