using System.ComponentModel.DataAnnotations;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Projekt;

public class QueryProjektResultDto
{
    [Key] public Guid ProjektId { get; set; }

    [StringLength(30)]
    [MinLength(3, ErrorMessage = "{0} må ikke være korter end {1} bogstaver. ")]
    [Required(ErrorMessage = "indtast et gyldig {0}")]
    public string ProjektTitle { get; set; }

    [Timestamp] public byte[] RowVersion { get; set; }
}