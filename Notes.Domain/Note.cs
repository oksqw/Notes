namespace Notes.Domain;

public class Note
{
    public Note(string title, string text) : this(Guid.NewGuid(), title, text, DateTime.Now)
    {
    }

    public Note(Guid id, string title, string text, DateTime createdAt, DateTime? updatedAt = null)
    {
        Id = id;
        Title = title;
        Text = text;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
    }
    
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}