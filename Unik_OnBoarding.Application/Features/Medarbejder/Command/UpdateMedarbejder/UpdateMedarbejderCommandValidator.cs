using FluentValidation;

namespace Unik_OnBoarding.Application.Features.Medarbejder.Command.UpdateMedarbejder;

public class UpdateMedarbejderCommandValidator : AbstractValidator<UpdateMedarbejderCommand>
{
    public UpdateMedarbejderCommandValidator()
    {
        RuleFor(m => m.MedarbejderId)
            .NotEmpty().WithMessage("Skal ikke være tomt")
            .NotNull();

        RuleFor(f => f.Fornavn)
            .NotEmpty().WithMessage("Skal ikke være tomt")
            .NotNull();

        RuleFor(e => e.Efternavn)
            .NotEmpty().WithMessage("Skal ikke være tomt")
            .NotNull();

        RuleFor(e => e.Email)
            .NotEmpty()
            .NotNull()
            .MaximumLength(50).WithMessage("Må ikke være længer end 50 bogstaver");

        RuleFor(t => t.Telefon)
            .NotEmpty().WithMessage("Skal ikke være tomt")
            .NotNull();

        RuleFor(j => j.Job)
            .NotEmpty().WithMessage("Skal ikke være tomt")
            .NotNull();
    }
}