using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Implementation.Booking.dto;

public class BookingUpdateDto
{
    [Key] public Guid BookId { get; set; }
    public Guid ProjektId { get; set; }
    public Guid OpgaveId { get; set; }
    public Guid MedarbejderId { get; set; }
    public int Duration { get; set; }

    // Navigation prop
    public OpgaverEntity Opgave { get; set; }

    [ForeignKey("ProjektId")] 
    public ProjektEntity Projekt { get; set; }

    [ForeignKey("MedarbejderId")] 
    public MedarbejderEntity Medarbejder { get; set; }

    [Required(ErrorMessage = "Startdato er påkrævet")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    [DisplayName("Start dato")]
    public DateTime StartDate { get; set; } = DateTime.UtcNow;

    [Required(ErrorMessage = "Slutdato er påkrævet")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    [DisplayName("Slut dato")]
    public DateTime EndDate { get; set; }

}