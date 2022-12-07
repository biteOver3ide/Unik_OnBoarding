using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Unik_OnBoarding.WebApp.Pages.Admin.ViewModel;

public class CreateBookingDto
{
    public Guid ProjectId { get; set; }
    public Guid OpgaveId { get; set; }
    public Guid MedarbejdeId { get; set; }

    [Required(ErrorMessage = "startdato er påkrævet")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    [DisplayName("Start dato")]
    public DateTime StartDate { get; set; } = DateTime.UtcNow;

    [Required(ErrorMessage = "slutdato er påkrævet")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    [DisplayName("Slut dato")]
    public DateTime EndDate { get; set; }
    public int Duration { get; set; }
}