using System.ComponentModel.DataAnnotations;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kompetence;

public class KompetenceCreateDto
{
    public Guid KompetenceId { get; set; }
    public string KompetenceName { get; set; }
    public string Beskrivelse { get; set; }
    public byte[] RowVersion { get; set; }
}