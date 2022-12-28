using AutoMapper;
using Unik_OnBoarding.Application.Features.Booking.Command.CreateBooking;
using Unik_OnBoarding.Application.Features.Booking.Command.UpdateBooking;
using Unik_OnBoarding.Application.Features.Kompetence.Command.CreateKompetence;
using Unik_OnBoarding.Application.Features.Kompetence.Command.UpdateKompetence;
using Unik_OnBoarding.Application.Features.Kunde.Command.CreateKunde;
using Unik_OnBoarding.Application.Features.Kunde.Command.UpdateKunde;
using Unik_OnBoarding.Application.Features.Medarbejder.Command.CreateMedarbejder;
using Unik_OnBoarding.Application.Features.Medarbejder.Command.UpdateMedarbejder;
using Unik_OnBoarding.Application.Features.Opgaver.Command.CreateOpgaver;
using Unik_OnBoarding.Application.Features.Opgaver.Command.UpdateOpgaver;
using Unik_OnBoarding.Application.Features.Projekt.Command.CreateProjekt;
using Unik_OnBoarding.Application.Features.Projekt.Command.UpdateProjekt;
using Unik_OnBoarding.Application.Implementation.Booking.dto;
using Unik_OnBoarding.Application.Implementation.Kompetencer.dto;
using Unik_OnBoarding.Application.Implementation.Kunde.dto;
using Unik_OnBoarding.Application.Implementation.Medarbejder.dto;
using Unik_OnBoarding.Application.Implementation.Opgaver.dto;
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
        CreateMap<MedarbejderEntity, UpdateMedarbejderCommand>()
	        .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName));

		// Automapping for Kompetencer
		CreateMap<KompetenceEntity, KompetenceDto>().ReverseMap();
        CreateMap<KompetenceEntity, KompetenceCreateDto>().ReverseMap();
        CreateMap<KompetenceEntity, KompetenceUpdateDto>().ReverseMap();
        CreateMap<KompetenceEntity, CreateKompetenceCommand>().ReverseMap();
        CreateMap<KompetenceEntity, UpdateKompetenceCommand>().ReverseMap();

        // Automapping for Opgaver
        CreateMap<OpgaverEntity, OpgaverDto>().ReverseMap();
        CreateMap<OpgaverEntity, OpgaverCreateDto>().ReverseMap();
        CreateMap<OpgaverEntity, OpgaverUpdateDto>().ReverseMap();
        CreateMap<OpgaverEntity, CreateOpgaverCommand>().ReverseMap();
        CreateMap<OpgaverEntity, UpdateOpgaverCommand>().ReverseMap();

        //Automapping for Booking 
        CreateMap<BookingEntity, BookingDto>().ReverseMap();
        CreateMap<BookingEntity, BookingCreateDto>().ReverseMap();
        CreateMap<BookingEntity, BookingUpdateDto>().ReverseMap();
        CreateMap<BookingEntity, CreateBookingCommand>().ReverseMap();
        CreateMap<BookingEntity, UpdateBookingCommand>().ReverseMap();
    }
}