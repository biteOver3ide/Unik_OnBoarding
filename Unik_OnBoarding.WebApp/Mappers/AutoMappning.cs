using AutoMapper;
using Unik_OnBoarding.Domain.Model;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Medarbejder;
using Unik_OnBoarding.WebApp.Pages.Medarbejder.ViewModel;

namespace Unik_OnBoarding.WebApp.Mappers;

public class AutoMappning : Profile
{
    public AutoMappning()
    {
        CreateMap<MedarbejderEntity, MedarbejderCreateViewModel>();
        CreateMap<MedarbejderEntity, MedarbejderCreateRequestDto>();
    }
}