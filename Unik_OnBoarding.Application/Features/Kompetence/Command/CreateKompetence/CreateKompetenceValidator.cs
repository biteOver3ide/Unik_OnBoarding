using FluentValidation;

namespace Unik_OnBoarding.Application.Features.Kompetence.Command.CreateKompetence;

public class CreateKompetenceValidator : AbstractValidator<CreateKompetenceCommand>
{
    public CreateKompetenceValidator()
    {
        RuleFor(b => b.Beskrivelse)
            .NotEmpty()
            .NotNull()
            .MaximumLength(150).WithMessage("Må ikke være længer end 150 bogstaver");
    }
}