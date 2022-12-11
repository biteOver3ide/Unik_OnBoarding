using FluentValidation;

namespace Unik_OnBoarding.Application.Features.Kompetence.Command.UpdateKompetence;

public class UpdateKompetenceValidator : AbstractValidator<UpdateKompetenceCommand>
{
    public UpdateKompetenceValidator()
    {
        RuleFor(k => k.KompetenceId)
            .NotEmpty().WithMessage("Skal ikke være tomt")
            .NotNull();

        RuleFor(b => b.Beskrivelse)
            .NotEmpty()
            .NotNull()
            .MaximumLength(150).WithMessage("Må ikke være længer end 50 bogstaver");
    }
}