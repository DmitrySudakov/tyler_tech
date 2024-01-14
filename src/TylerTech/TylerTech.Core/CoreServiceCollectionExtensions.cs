using Microsoft.Extensions.DependencyInjection;
using TylerTech.Core.Integrations.EfmClient;

namespace TylerTech.Core;

public static class CoreServiceCollectionExtensions
{
    public static IServiceCollection AddCoreServices(this IServiceCollection services)
    {
        services.AddTransient<IEfmClient, EfmClient>();

        return services;
    }
}
