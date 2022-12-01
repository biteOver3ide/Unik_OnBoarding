﻿using FluentValidation;

namespace Unik_OnBoarding.Application.Features.Stamdata.Medarbejder.Command.CreateMedarbejder;

public class CreateMedarbejderValidator : AbstractValidator<CreateMedarbejderCommand>
{
    public CreateMedarbejderValidator()
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