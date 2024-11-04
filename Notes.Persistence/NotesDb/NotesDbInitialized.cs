using Notes.Application.Interfaces;

namespace Notes.Persistence.NotesDb;

public class NotesDbInitialized
{
    public static void Initialize(NotesDbContext context) => context.Database.EnsureCreated();
}