using FluentValidation;

namespace Unik_OnBoarding.Application.Features.Stamdata.Command.UpdateProjekt;

public class UpdateCommandValidator : AbstractValidator<UpdateProjektCommand>
{
    public UpdateCommandValidator()
    {
        RuleFor(p => p.ProjektTitle)
            .NotNull()
            .NotEmpty()
            //.MaximumLength(50)
            .MaximumLength(2).WithMessage("check din input længde");
    }
}