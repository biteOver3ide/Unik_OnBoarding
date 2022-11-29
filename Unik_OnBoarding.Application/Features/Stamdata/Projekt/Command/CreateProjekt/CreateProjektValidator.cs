using FluentValidation;

namespace Unik_OnBoarding.Application.Features.Stamdata.Command.CreateProjekt;

public class CreateProjektValidator : AbstractValidator<CreateProjektCommand>
{
    public CreateProjektValidator()
    {
        RuleFor(p => p.ProjektTitle)
            .NotEmpty()
            .NotNull()
            .MaximumLength(50).WithMessage("max 50 bogstaver");

        RuleFor(k => k.KundeId)
            .NotNull().WithMessage("Skal ikke være tomt")
            .NotEmpty();
    }
}