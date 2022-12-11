using FluentValidation;

namespace Unik_OnBoarding.Application.Features.Projekt.Command.CreateProjekt;

public class CreateProjektValidator : AbstractValidator<CreateProjektCommand>
{
    public CreateProjektValidator()
    {
        RuleFor(p => p.ProjektTitle)
            .NotEmpty()
            .NotNull()
            .MaximumLength(50).WithMessage("max 50 bogstaver");
    }
}