using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using MediatR;

namespace Unik_OnBoarding.Application;

public static class AppContainerConfiguration
{
    public static IServiceCollection AppServiceCollection(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(Assembly.GetExecutingAssembly());
        return services;
    }
}