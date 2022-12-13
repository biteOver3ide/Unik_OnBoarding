using System.ComponentModel.DataAnnotations;
using System.Data;
using MediatR;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Features.Booking.Command.UpdateBooking;

public class UpdateBookingCommand : IRequest
{
    public Guid BookingId { get; set; }
    public OpgaverEntity Opgave { get; set; }
    public ProjektEntity Projekt { get; set; }
    public MedarbejderEntity Medarbejder { get; set; }
    public DateTime StartDate { get; set; } = DateTime.UtcNow;
    public DateTime EndDate { get; set; }

    [Timestamp] public byte[] RowVersion { get; set; }
}