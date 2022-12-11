using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Implementation.Projekt.dto;

public class ProjektUpdateDto
{
    [Key] public Guid ProjektId { get; set; }

    public string? ProjektTitle { get; set; }

    public KundeEntity Kunde { get; set; }

    public Guid KundeId { get; set; }
}