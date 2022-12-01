﻿using MediatR;
using Unik_OnBoarding.Application.Implementation.Medarbejder.dto;

namespace Unik_OnBoarding.Application.Features.Stamdata.Medarbejder.Queries.GetMedarbejderDetail;

public class GetMedarbejderDetailQuery : IRequest<MedarbejderDto>
{
    public Guid MedarbejderId { get; set; }
}