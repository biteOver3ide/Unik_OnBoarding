using System.ComponentModel.DataAnnotations;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kunde
{
    public class UpdateKundeDto
    {

        public Guid Kid { get; set; }

        [StringLength(30)]
        [MinLength(3, ErrorMessage = "{0} må ikke være korter end {1} bogstaver. ")]
        [Required(ErrorMessage = "indtast et gyldig {0}")]
        public string Fornavn { get; set; }

        [StringLength(30)]
        [MinLength(3, ErrorMessage = "{0} må ikke være korter end {1} bogstaver. ")]
        [Required(ErrorMessage = "indtast et gyldig {0}")]
        public string Efternavn { get; set; }

        [StringLength(30)]
        [MinLength(3, ErrorMessage = "{0} må ikke være korter end {1} bogstaver. ")]
        [Required(ErrorMessage = "indtast et gyldig {0}")]
        public string Firmanavn { get; set; }

        [Required(ErrorMessage = "indtast en gyldig {0} nummer")]
        public int Cvr { get; set; }

        [EmailAddress]
        [StringLength(40)]
        [Required(ErrorMessage = "indtast en gyldig {0}")]
        public string Email { get; set; }

        [Phone]
        [StringLength(12)]
        [MinLength(8, ErrorMessage = "{0} må ikke være korter end {1} tal. ")]
        [Required(ErrorMessage = "indtast en gyldig telefon nummer")]
        public string Telefon { get; set; }

        [StringLength(50)]
        [MinLength(3, ErrorMessage = "{0} må ikke være korter end {1} bogstaver. ")]
        [Required(ErrorMessage = "indtast et gyldig {0}")]
        public string Adresse { get; set; }

        //public List<ProjektEntity>? Projekt { get; set; }

        [Timestamp] public byte[ ] RowVersion { get; set; }
    }
}
