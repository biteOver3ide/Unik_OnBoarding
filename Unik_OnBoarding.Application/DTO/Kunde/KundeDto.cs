﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Unik_OnBoarding.Application.DTO.Kunde;

public class KundeDto
{
    [Key] // Server side validation
    public Guid Kid { get; set; } // autogenerated unik number med Bogstaver og number

    public string Name { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }
    public int Telefon { get; set; }

}