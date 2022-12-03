using FluentValidation;

namespace Unik_OnBoarding.Application.Features.Stamdata.Projekt.Command.UpdateProjekt;

public class UpdateCommandKProjektValidator : AbstractValidator<UpdateProjektCommand>
{
    public UpdateCommandKProjektValidator()
    {
        RuleFor(p => p.ProjektTitle)
            .NotNull()
            .NotEmpty()
            //.MaximumLength(50)
            .MaximumLength(2).WithMessage("check din input længde");
    }
}