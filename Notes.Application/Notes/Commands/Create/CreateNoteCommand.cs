namespace Notes.Application.Notes.Commands.Create;

public class CreateNoteCommand : NoteCommand
{
    public CreateNoteCommand(string title, string text) : base(title, text){}
}