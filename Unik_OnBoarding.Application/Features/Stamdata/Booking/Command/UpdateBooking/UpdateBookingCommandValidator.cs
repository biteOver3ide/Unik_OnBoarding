﻿using FluentValidation;

namespace Unik_OnBoarding.Application.Features.Stamdata.Booking.Command.UpdateBooking;

public class UpdateBookingCommandValidator : AbstractValidator<UpdateBookingCommand>
{
    public UpdateBookingCommandValidator()
    {
        RuleFor(b => b.BookingId)
            .NotEmpty().WithMessage("Skal ikke være tomt")
            .NotNull();
    }
}