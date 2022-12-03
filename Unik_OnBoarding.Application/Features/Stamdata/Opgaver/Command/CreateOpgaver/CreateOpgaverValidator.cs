using FluentValidation;

namespace Unik_OnBoarding.Application.Features.Stamdata.Opgaver.Command.CreateOpgaver;

public class CreateOpgaverValidator : AbstractValidator<CreateOpgaverCommand>
{
    public CreateOpgaverValidator()
    {
        RuleFor(o => o.OpgaveId)
            .NotEmpty().WithMessage("Skal ikke være tomt")
            .NotNull();

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