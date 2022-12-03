using MediatR;
using Unik_OnBoarding.Application.Implementation.Opgaver.dto;

namespace Unik_OnBoarding.Application.Features.Stamdata.Opgaver.Queries.GetOpgaverList;

public class GetOpgaverListQuery : IRequest<List<OpgaverDto>>
{
    
}