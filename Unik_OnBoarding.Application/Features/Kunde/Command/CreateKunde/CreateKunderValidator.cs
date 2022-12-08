using FluentValidation;

namespace Unik_OnBoarding.Application.Features.Kunde.Command.CreateKunde;

public class CreateKunderValidator : AbstractValidator<CreateKunderCommand>
{
    public CreateKunderValidator()
    {
        RuleFor(k => k.Kid)
            .NotEmpty().WithMessage("Skal ikke være tomt")
            .NotNull();

        RuleFor(e => e.Email)
            .NotEmpty()
            .NotNull()
            .MaximumLength(50).WithMessage("Må ikke være længer end 50 bogstaver");

        RuleFor(t => t.Telefon)
            .NotEmpty().WithMessage("Skal ikke være tomt")
            .NotNull();
    }
}