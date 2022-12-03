using FluentValidation;

namespace Unik_OnBoarding.Application.Features.Stamdata.Kompetence.Command.CreateKompetence;

public class CreateKompetenceValidator : AbstractValidator<CreateKompetenceCommand>
{
    public CreateKompetenceValidator()
    {
        RuleFor(k => k.KompetenceId)
            .NotEmpty().WithMessage("Skal ikke være tomt")
            .NotNull();

        RuleFor(n => n.KompetenceName)
            .NotEmpty()
            .NotNull()
            .MaximumLength(50).WithMessage("Må ikke være længer end 50 bogstaver");

        RuleFor(b => b.Beskrivelse)
            .NotEmpty()
            .NotNull()
            .MaximumLength(150).WithMessage("Må ikke være længer end 50 bogstaver");
    }
}