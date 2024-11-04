namespace Notes.WebApi.DTO;

public class CreateNoteDTO
{
    public CreateNoteDTO(string text, string title)
    {
        Text = text;
        Title = title;
    }

    public string Text { get; set; }
    
    public string Title { get; set; }
}