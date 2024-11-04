using FluentValidation;
using Notes.Application.Common;

namespace Notes.Application.Notes.Commands.Update;

public class UpdateNoteCommandValidator : AbstractValidator<UpdateNoteCommand>
{
    public UpdateNoteCommandValidator()
    {
        RuleFor(x => x.Id).NotNull().NotEqual(Guid.Empty);
        RuleFor(x => x.Title).NotEmpty().MaximumLength(Constants.NOTE_TITLE_MAX_LENGTH);
        RuleFor(x => x.Text).NotEmpty().MaximumLength(Constants.NOTE_TEXT_MAX_LENGTH);
    }
}