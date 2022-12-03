﻿using MediatR;
using Unik_OnBoarding.Application.Implementation.Opgaver.dto;

namespace Unik_OnBoarding.Application.Features.Stamdata.Opgaver.Queries.GetOpgaverDetail;

public class GetOpgaverDetailQuery : IRequest<OpgaverDto>
{
    public Guid OpgaverId { get; set; }
}