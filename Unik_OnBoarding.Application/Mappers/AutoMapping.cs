using AutoMapper;
using Unik_OnBoarding.Application.Features.Stamdata.Command.CreateProjekt;
using Unik_OnBoarding.Application.Features.Stamdata.Command.UpdateProjekt;
using Unik_OnBoarding.Application.Features.Stamdata.Kunde.Command.CreateKunde;
using Unik_OnBoarding.Application.Features.Stamdata.Kunde.Command.UpdateKunde;
using Unik_OnBoarding.Application.Features.Stamdata.Medarbejder.Command.CreateMedarbejder;
using Unik_OnBoarding.Application.Features.Stamdata.Medarbejder.Command.UpdateMedarbejder;
using Unik_OnBoarding.Application.Implementation.Kunde.dto;
using Unik_OnBoarding.Application.Implementation.Medarbejder.dto;
using Unik_OnBoarding.Application.Implementation.Projekt.dto;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Mappers;

public class AutoMapping : Profile
{
    public AutoMapping()
    {
        // Automapping for Projekt
        CreateMap<ProjektEntity, ProjektDto>().ReverseMap();
        CreateMap<ProjektEntity, ProjektCreateDto>().ReverseMap();
        CreateMap<ProjektEntity, ProjektUpdateDto>().ReverseMap();
        CreateMap<ProjektEntity, CreateProjektCommand>().ReverseMap();
        CreateMap<ProjektEntity, UpdateProjektCommand>().ReverseMap();

        // Automapping for Kunde
        CreateMap<KundeEntity, KundeDto>().ReverseMap();
        CreateMap<KundeEntity, KundeCreateDto>().ReverseMap();
        CreateMap<KundeEntity, KundeUpdateDto>().ReverseMap();
        CreateMap<KundeEntity, CreateKunderCommand>().ReverseMap();
        CreateMap<KundeEntity, UpdateKunderCommand>().ReverseMap();

        // Automapping for Medarbejder
        CreateMap<MedarbejderEntity, MedarbejderDto>().ReverseMap();
        CreateMap<MedarbejderEntity, MedarbejderCreateDto>().ReverseMap();
        CreateMap<MedarbejderEntity, MedarbejderUpdateDto>().ReverseMap();
        CreateMap<MedarbejderEntity, CreateMedarbejderCommand>().ReverseMap();
        CreateMap<MedarbejderEntity, UpdateMedarbejderCommand>().ReverseMap();
    }
}