using System.ComponentModel.DataAnnotations;

namespace Unik_OnBoarding.Domain.Model;

public class MedarbejderEntity
{
    [Key] public Guid MedarbejderId { get; set; }

    public string Fornavn { get; set; }

    public string Efternavn { get; set; }

    public string Email { get; set; }

    public string Telefon { get; set; }

    public Jobtitler Job { get; set; }

    //public IReadOnlyCollection<KompetenceEntity>? Kompetencer { get; set; }

    [Timestamp]
    public byte[] RowVersion { get; set; }
}   