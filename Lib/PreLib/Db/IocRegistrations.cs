using Microsoft.Extensions.DependencyInjection;

using Database.BaseClasses;
using Database.BaseClasses.Interfaces;

namespace Database;

public static class IocRegistrations
{
    public static IServiceCollection AddCrudRegistrations(this IServiceCollection services)
    {
        services.AddTransient<IContextGenerator, ContextGenerator>();

        return services;
    }
}