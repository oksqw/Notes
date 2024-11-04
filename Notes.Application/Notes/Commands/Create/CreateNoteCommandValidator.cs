using FluentValidation;
using Notes.Application.Common;

namespace Notes.Application.Notes.Commands.Create;

public class CreateNoteCommandValidator : AbstractValidator<CreateNoteCommand>
{
    public CreateNoteCommandValidator()
    {
        RuleFor(x => x.Title).NotEmpty().MaximumLength(Constants.NOTE_TITLE_MAX_LENGTH);
        RuleFor(x => x.Text).NotEmpty().MaximumLength(Constants.NOTE_TEXT_MAX_LENGTH);
    }
}