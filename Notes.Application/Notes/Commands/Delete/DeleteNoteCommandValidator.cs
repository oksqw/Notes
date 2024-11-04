using FluentValidation;

namespace Notes.Application.Notes.Commands.Delete;

public class DeleteNoteCommandValidator : AbstractValidator<DeleteNoteCommand>
{
    public DeleteNoteCommandValidator() => 
        RuleFor(x => x.Id).NotNull().NotEqual(Guid.Empty);
}