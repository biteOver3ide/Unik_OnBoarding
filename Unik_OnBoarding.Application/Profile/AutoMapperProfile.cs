using Unik_OnBoarding.Application.DTO.Kunde;
using Unik_OnBoarding.Application.DTO.Projekt;
using Unik_OnBoarding.Domain;
using AutoMapper;

namespace Unik_OnBoarding.Application.Profile;

public class AutoMapperProfile : AutoMapper.Profile
{
    public AutoMapperProfile()
    {
        // Automapping for Projekt
        CreateMap<Projekt, ProjektDto>().ReverseMap();
        CreateMap<Projekt, ProjektCreateDto>().ReverseMap();
        CreateMap<Projekt, ProjektUpdateDto>().ReverseMap();

        // Automapping for Kunde
        CreateMap<Kunde, KundeDto>().ReverseMap();
        CreateMap<Kunde, KundeCreateDto>().ReverseMap();
        CreateMap<Kunde, KundeUpdateDto>().ReverseMap();
    }
}