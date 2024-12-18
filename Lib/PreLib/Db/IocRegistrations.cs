using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Database;

public static class IocRegistrations
{
    public static IServiceCollection AddCrudRegistrations(this IServiceCollection services)
    {
        services.AddTransient<IContextGenerator, ContextGenerator>();

        return services;
    }
}