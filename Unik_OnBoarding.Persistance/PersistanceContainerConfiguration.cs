using Microsoft.Extensions.DependencyInjection;
using Unik_OnBoarding.Application.Interfaceses;
using Unik_OnBoarding.Domain.DomainService;
using Unik_OnBoarding.Persistance.DomainService;
using Unik_OnBoarding.Persistance.Repositories;

namespace Unik_OnBoarding.Persistance;

public static class PersistanceContainerConfiguration
{
    public static IServiceCollection AddPersistenceService(this IServiceCollection service)
    {
        service.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepo<>));
        service.AddScoped(typeof(IProjectRepository), typeof(ProjektRepo));
        service.AddScoped(typeof(IKundeRepository), typeof(KundeRepo));
        service.AddScoped(typeof(IMedarbejderRepository), typeof(MedarbejderRepo));
        service.AddScoped(typeof(IBookingRepository), typeof(BookingRepo));
        service.AddScoped(typeof(IKompetencerRepository), typeof(KompetenceRepo));
        service.AddScoped(typeof(IOpgaverRepository), typeof(OpgaverRepo));
        service.AddScoped(typeof(IBookingDomainService),typeof(BookingDomainService));

        return service;
    }
}