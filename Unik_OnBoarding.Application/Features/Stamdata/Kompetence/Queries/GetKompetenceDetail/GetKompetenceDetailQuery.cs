﻿using MediatR;
using Unik_OnBoarding.Application.Implementation.Kompetencer.dto;

namespace Unik_OnBoarding.Application.Features.Stamdata.Kompetence.Queries.GetKompetenceDetail;

public class GetKompetenceDetailQuery : IRequest<KompetenceDto>
{
    public Guid KompetencerId { get; set; }
}