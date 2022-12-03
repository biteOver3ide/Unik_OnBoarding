﻿using AutoMapper;
using Unik_OnBoarding.Application.Features.Stamdata.Booking.Command.CreateBooking;
using Unik_OnBoarding.Application.Features.Stamdata.Booking.Command.UpdateBooking;
using Unik_OnBoarding.Application.Features.Stamdata.Command.CreateProjekt;
using Unik_OnBoarding.Application.Features.Stamdata.Command.UpdateProjekt;
using Unik_OnBoarding.Application.Features.Stamdata.Kompetence.Command.CreateKompetence;
using Unik_OnBoarding.Application.Features.Stamdata.Kompetence.Command.UpdateKompetence;
using Unik_OnBoarding.Application.Features.Stamdata.Kunde.Command.CreateKunde;
using Unik_OnBoarding.Application.Features.Stamdata.Kunde.Command.UpdateKunde;
using Unik_OnBoarding.Application.Features.Stamdata.Medarbejder.Command.CreateMedarbejder;
using Unik_OnBoarding.Application.Features.Stamdata.Medarbejder.Command.UpdateMedarbejder;
using Unik_OnBoarding.Application.Features.Stamdata.Opgaver.Command.CreateOpgaver;
using Unik_OnBoarding.Application.Features.Stamdata.Opgaver.Command.UpdateOpgaver;
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