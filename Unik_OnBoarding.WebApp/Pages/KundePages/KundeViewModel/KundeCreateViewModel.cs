﻿using System.ComponentModel.DataAnnotations;

namespace Unik_OnBoarding.WebApp.Pages.KundePages.KundeViewModel;

public class KundeCreateDto
{
    public string Name { get; set; }

    [Required] public string Adresse { get; set; }

    [Required][EmailAddress] public string Email { get; set; }

    public int Telefon { get; set; }
}