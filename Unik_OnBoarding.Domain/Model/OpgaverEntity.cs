using System.ComponentModel.DataAnnotations;

namespace Unik_OnBoarding.Domain.Model;

public class OpgaverEntity
{
    [Key] public Guid OpgaveId { get; set; }

    [Required]
    [MaxLength(100, ErrorMessage = "Titellængden bør maksimalt være 100 tegn")]
    [MinLength(10, ErrorMessage = "Titellængden bør mindst være 10 tegn")]
    public string OpgaveName { get; set; }

    public string Beskrivelse { get; set; }
}