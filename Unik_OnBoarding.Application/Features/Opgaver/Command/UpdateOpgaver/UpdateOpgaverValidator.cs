using FluentValidation;

namespace Unik_OnBoarding.Application.Features.Opgaver.Command.UpdateOpgaver;

public class UpdateOpgaverValidator : AbstractValidator<UpdateOpgaverCommand>
{
    public UpdateOpgaverValidator()

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