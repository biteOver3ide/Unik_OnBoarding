using AutoMapper;
using Unik_OnBoarding.Application.DTO.Kunde;
using Unik_OnBoarding.Application.DTO.Projekt;
using Unik_OnBoarding.Application.Features.Stamdata.Command.CreateProjekt;
using Unik_OnBoarding.Application.Features.Stamdata.Command.UpdateProjekt;
using Unik_OnBoarding.Domain;
using AutoMapper;
using Unik_OnBoarding.Application.Features.Stamdata.Queries.GetProjektList;

namespace Unik_OnBoarding.Application.Mappers;

public class AutoMapping : Profile
{
    public AutoMapping()
    {
        // Automapping for Projekt
        CreateMap<Projekt, ProjectViewModel>().ReverseMap();
        CreateMap<Projekt, ProjektCreateDto>().ReverseMap();
        CreateMap<Projekt, ProjektUpdateDto>().ReverseMap();
        CreateMap<Projekt, CreateProjektCommand>().ReverseMap();
        CreateMap<Projekt, UpdateProjektCommand>().ReverseMap();

        // Automapping for Kunde
        CreateMap<Kunde, KundeDto>().ReverseMap();
        CreateMap<Kunde, KundeCreateDto>().ReverseMap();
        CreateMap<Kunde, KundeUpdateDto>().ReverseMap();
    }
}