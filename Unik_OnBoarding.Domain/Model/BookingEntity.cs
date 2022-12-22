using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unik_OnBoarding.Domain.Model;

public class BookingEntity
{
    [Key] public Guid BookId { get; set; }

    public Guid ProjektId { get; set; }

    [ForeignKey("ProjektId")] public ProjektEntity Projekt { get; set; }

    public Guid OpgaveId { get; set; }

    [ForeignKey("OpgaveId")] public OpgaverEntity Opgave { get; set; }

    public Guid MedarbejderId { get; set; }

    [ForeignKey("MedarbejderId")] public MedarbejderEntity Medarbejder { get; set; }

    [Required(ErrorMessage = "Startdato er påkrævet")]
    [DataType(DataType.Date)]
    [DisplayName("Start dato")]
    public DateTime StartDate { get; set; } = DateTime.UtcNow;

    [Required(ErrorMessage = "Slutdato er påkrævet")]
    [DataType(DataType.Date)]
    [DisplayName("Slut dato")]
    public DateTime EndDate { get; set; }

    public int Duration { get; set; }

    public string? Beskrivelse { get; set; }

    [Timestamp] public byte[] RowVersion { get; set; }

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