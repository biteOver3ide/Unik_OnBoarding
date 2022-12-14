using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Booking;

public class CreateBookingDto
{
    public Guid ProjektId { get; set; }
    public Guid OpgaveId { get; set; }
    public Guid MedarbejderId { get; set; }
    
    [Required(ErrorMessage = "startdato er påkrævet")]
    [DataType(DataType.Date)]
    [DisplayName("Start dato")]
    public DateTime StartDate { get; set; }

    [Required(ErrorMessage = "slutdato er påkrævet")]
    [DataType(DataType.Date)]
    [DisplayName("Slut dato")]
    public DateTime EndDate { get; set; }

    public int Duration { get; set; }

    
}