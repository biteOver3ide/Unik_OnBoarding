﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Booking;

public class BookingCreateDto
{
    public Guid ProjectId { get; set; }
    public Guid OpgaveId { get; set; }
    public Guid MedarbejdeId { get; set; }

    [Required(ErrorMessage = "startdato er påkrævet")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    [DisplayName("Start dato")]
    public DateTime StartDate { get; set; } = DateTime.UtcNow;

    [Required(ErrorMessage = "slutdato er påkrævet")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    [DisplayName("Slut dato")]
    public DateTime EndDate { get; set; }
    public int Duration { get; set; }
    public byte[] RowVersion { get; set; }
}