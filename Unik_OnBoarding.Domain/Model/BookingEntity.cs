using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unik_OnBoarding.Domain.Model;

public class BookingEntity
{
    public BookingEntity()
    {
    }

    public BookingEntity(Guid bookId, Guid projektid, Guid opgaveId, Guid medarbejderId, DateTime startDate,
        DateTime endDate)
    {
        BookId = bookId;
        ProjektId = projektid;
        OpgaveId = opgaveId;
        MedarbejderId = medarbejderId;
        StartDate = startDate;
        EndDate = endDate;
        Duration = BusinessDaysLeft(startDate, EndDate);
    }
    [Key]
    public Guid BookId { get; set; }
    public int Duration { get; set; }
    public Guid ProjektId { get; set; }
    public Guid OpgaveId { get; set; }
    public Guid MedarbejderId { get; set; }

    [Timestamp]
    public byte[] RowVersion { get; set; }

    // Navigation prop

    [ForeignKey("OpgaveId")]
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

    private int BusinessDaysLeft(DateTime first, DateTime last)
    {
        var count = 0;

        while (first.Date != last.Date)
        {
            if (first.DayOfWeek != DayOfWeek.Saturday && first.DayOfWeek != DayOfWeek.Sunday)
                count++;

            first = first.AddDays(1);
        }

        return count;
    }
}