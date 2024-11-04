using FluentValidation;

namespace Notes.Application.Notes.Queries.Get;

public class GetNoteQueryValidator : AbstractValidator<GetNoteQuery>
{
    public GetNoteQueryValidator() => 
        RuleFor(x => x.Id).NotNull().NotEqual(Guid.Empty);
}