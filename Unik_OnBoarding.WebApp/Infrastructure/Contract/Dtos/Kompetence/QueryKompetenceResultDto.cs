using System.ComponentModel.DataAnnotations;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kompetence;

public class QueryKompetenceResultDto
{
    public Guid KompetenceId { get; set; }

    public Jobtitler Job { get; set; }

    [StringLength(100)]
    [MinLength(3, ErrorMessage = "{0} må ikke være korter end {1} bogstaver. ")]
    [Required(ErrorMessage = "indtast et gyldig {0}")]
    public string Beskrivelse { get; set; }

    [Timestamp] public byte[] RowVersion { get; set; }
}