using FluentValidation;
using Unik_OnBoarding.Application.Features.Stamdata.Kompetence.Command.CreateKompetence;

namespace Unik_OnBoarding.Application.Features.Stamdata.Kompetence.Command.UpdateKompetence;

public class UpdateKompetenceValidator : AbstractValidator<UpdateKompetenceCommand>
{
    public UpdateKompetenceValidator()
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