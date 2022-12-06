﻿using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Medarbejder;

public class MedarbejderUpdateDto
{
    public Guid MedarbejderId { get; set; }
    public string Fornavn { get; set; }
    public string Efternavn { get; set; }
    public string Email { get; set; }
    public string Telefon { get; set; }
    public Jobtitler Job { get; set; }
    public byte[] RowVersion { get; set; }
}