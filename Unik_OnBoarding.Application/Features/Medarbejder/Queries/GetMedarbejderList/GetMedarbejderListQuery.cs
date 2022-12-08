using MediatR;
using Unik_OnBoarding.Application.Implementation.Medarbejder.dto;

namespace Unik_OnBoarding.Application.Features.Medarbejder.Queries.GetMedarbejderList;

public class GetMedarbejderListQuery : IRequest<List<MedarbejderDto>>
{
    
}