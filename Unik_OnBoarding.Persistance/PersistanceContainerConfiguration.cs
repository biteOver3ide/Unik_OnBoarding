using Microsoft.Extensions.DependencyInjection;
using Unik_OnBoarding.Application.Interfaceses;
using Unik_OnBoarding.Persistance.Repositories;

namespace Unik_OnBoarding.Persistance;

public static class PersistanceContainerConfiguration
{
    public static IServiceCollection AddPersistenceService(this IServiceCollection service)
    {
        service.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
        service.AddScoped(typeof(IProjectRepository), typeof(ProjektRepository));

        return service;
    }
}