namespace Notes.Application.Notes.Commands.Update;

public class UpdateNoteCommand : NoteCommand
{
    public UpdateNoteCommand(Guid id, string title, string text) : base(title, text) => Id = id;
    public Guid Id { get; set; }
}