﻿using MediatR;
using Unik_OnBoarding.Application.DTO.Kunde;

namespace Unik_OnBoarding.Application.Features.Stamdata.Kunde.Queries.GetKundeDetail;

public class GetKundeDetailQuery : IRequest<KundeDto>
{
    public Guid Kid { get; set; }
}