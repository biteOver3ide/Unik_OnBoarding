using FluentValidation;

namespace Unik_OnBoarding.Application.Features.Stamdata.Kunde.Command.UpdateKunde;

public class UpdateCommandKundeValidator : AbstractValidator<UpdateKunderCommand>
{
    public UpdateCommandKundeValidator()
    {
        RuleFor(k => k.Kid)
            .NotEmpty().WithMessage("Skal ikke være tomt")
            .NotNull();
    }
}