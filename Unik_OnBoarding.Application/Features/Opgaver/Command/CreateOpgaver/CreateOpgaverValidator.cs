using FluentValidation;

namespace Unik_OnBoarding.Application.Features.Opgaver.Command.CreateOpgaver;

public class CreateOpgaverValidator : AbstractValidator<CreateOpgaverCommand>
{
    public CreateOpgaverValidator()
    {

	    RuleFor(b => b.Beskrivelse)
            .NotEmpty()
            .NotNull()
            .MaximumLength(50).WithMessage("Må ikke være længer end 50 bogstaver");

        RuleFor(o => o.OpgaveName)
            .NotEmpty()
            .NotNull()
            .MaximumLength(50).WithMessage("Må ikke være længer end 50 bogstaver");
    }
}