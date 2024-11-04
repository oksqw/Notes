namespace Notes.Application.Exceptions;

public class NoteNotFoundException(Guid id) : Exception($"Note {id} not found");