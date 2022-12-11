using System.ComponentModel.DataAnnotations;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Implementation.Kompetencer.dto;

public class KompetenceDto
{
    public Guid KompetenceId { get; set; }

    public Jobtitler Job { get; set; }

    public string Beskrivelse { get; set; }

    [Timestamp] public byte[] RowVersion { get; set; }
}