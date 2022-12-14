using FluentValidation;

namespace Unik_OnBoarding.Application.Features.Booking.Command.CreateBooking;

public class CreateBookingValidator : AbstractValidator<CreateBookingCommand>
{
    public CreateBookingValidator()
    {
        //RuleFor(b => b.BookingId)
        //    .NotEmpty().WithMessage("Skal ikke være tomt")
        //    .NotNull();
    }
}